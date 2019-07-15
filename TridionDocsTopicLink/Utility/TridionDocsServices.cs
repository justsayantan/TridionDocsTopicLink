using TridionDocsTopicLink.Helper;
using TridionDocsTopicLink.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Xml;
using SDLKC2016WSSample.PublicationOutput25ServiceReference;
//using SDLKC2016WSSample.DocumentObj20ServiceReference;
//using SDLKC2016WSSample.DocumentObj25ServiceReference;

namespace TridionDocsTopicLink.Utility
{
    public static class TridionDocsServices
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

        public static List<Publication> ReadPublicationFromDocs(InfoShareWSHelper infoShareWsHelper)
        {
            List<Publication> publications = new List<Publication>();
            var object25Channel = infoShareWsHelper.GetPublication25Channel();
            string ishMeta =
            "<ishfields>" +
            "<ishfield name='FTITLE' level='logical'/>" +
            "<ishfield name='MODIFIED-ON' level='lng'/>" +
            "<ishfield name='FSTATUS' level='lng'/>" +
            "<ishfield name='FISHPUBLICATIONTYPE' level='logical'/>" +
               //"<ishfield name = 'MODIFIED-ON' level='lng' />" +
               //< ishfield name = "FISHPUBSOURCELANGUAGES" level = "version" />
               // <ishfield name="FISHPUBLICATIONTYPE" level="logical" />
               "</ishfields>";
            string obj = object25Channel.Find(StatusFilter.ISHNoStatusFilter, "", ishMeta);
            publications = BindPublication(obj);
            return publications;
        }

        private static List<Publication> BindPublication(string obj)
        {
            List<Publication> publications = new List<Publication>();
            XmlDocument docsElement = new XmlDocument();
            docsElement.LoadXml(obj);

            foreach (XmlNode node in docsElement.SelectNodes("/ishobjects/ishobject"))
            {
                Publication publication = new Publication();
                publication.Id = node.Attributes["ishref"].Value;
                XmlDocument innerDocsElement = new XmlDocument();
                innerDocsElement.LoadXml(node.InnerXml);
                foreach (XmlNode childNodes in innerDocsElement.SelectNodes("/ishfields/ishfield"))
                {
                    switch (childNodes.Attributes["name"].Value)
                    {
                        case "FTITLE":
                            publication.Title = childNodes.InnerText;
                            break;
                        case "MODIFIED-ON":
                            publication.ModifiedOn = childNodes.InnerText;
                            break;
                        case "FSTATUS":
                            publication.Status = childNodes.InnerText;
                            break;
                        case "FISHPUBLICATIONTYPE":
                            publication.PublicationType = childNodes.InnerText;
                            break;
                        default:
                            break;
                    }
                }
                publications.Add(publication);
            }
            return publications;
        }
    }
}