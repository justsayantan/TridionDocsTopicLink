using TridionDocsTopicLink.Helper;
using TridionDocsTopicLink.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Xml;
//using SDLKC2016WSSample.PublicationOutput25ServiceReference;
using SDLKC2016WSSample.DocumentObj20ServiceReference;
using SDLKC2016WSSample.DocumentObj25ServiceReference;

namespace TridionDocsTopicLink.Utility
{
    public static class TridionDocsServicesForTopic
    {
        public static InfoShareWSHelper ConnectToTridionDocs()
        {
            var serviceUri = ConfigurationManager.AppSettings["cmserviceurl"];
            var serviceUser = ConfigurationManager.AppSettings["cmserviceusername"];
            var servicePassword = ConfigurationManager.AppSettings["cmservicepassword"];
            Uri serviceUrl = new Uri(serviceUri);
            InfoShareWSHelper wsHelper = new InfoShareWSHelper(serviceUrl)
            {
                Username = serviceUser,
                Password = servicePassword
            };
            wsHelper.Resolve();
            //Issue a token. In other words authenticate
            wsHelper.IssueToken();
            return wsHelper;
        }

        public static List<Topic> ReadTopicsFromDocs(InfoShareWSHelper infoShareWsHelper)
        {
            List<Topic> topics = new List<Topic>();
            var object25Channel = infoShareWsHelper.GetDocumentObj25Channel();
            string ishMeta =
            "<ishfields>" +
            "<ishfield name='FTITLE' level='logical'/>" +
            "<ishfield name='FAUTHOR' level='lng'/>" +
            "<ishfield name='FSTATUS' level='lng'/>" +
            "</ishfields>";
            string obj = object25Channel.Find(ISHType.ISHModule.ToString(), StatusFilter.ISHNoStatusFilter, "", ishMeta);
            topics = BindTopic(obj);
            return topics;
        }




        private static List<Topic> BindTopic(string obj)
        {
            List<Topic> topics = new List<Topic>();
            XmlDocument docsElement = new XmlDocument();
            docsElement.LoadXml(obj);

            foreach (XmlNode node in docsElement.SelectNodes("/ishobjects/ishobject"))
            {
                Topic topic = new Topic();
                topic.Id = node.Attributes["ishref"].Value;
                XmlDocument innerDocsElement = new XmlDocument();
                innerDocsElement.LoadXml(node.InnerXml);
                foreach (XmlNode childNodes in innerDocsElement.SelectNodes("/ishfields/ishfield"))
                {
                    switch (childNodes.Attributes["name"].Value)
                    {
                        case "FTITLE":
                            topic.Title = childNodes.InnerText;
                            break;
                        case "FAUTHOR":
                            topic.Author = childNodes.InnerText;
                            break;
                        case "FSTATUS":
                            topic.Status = childNodes.InnerText;
                            break;
                        default:
                            break;
                    }
                }
                topics.Add(topic);
            }
            return topics;
        }
    }
}