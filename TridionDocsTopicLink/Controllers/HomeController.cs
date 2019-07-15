using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TridionDocsTopicLink.Helper;
using TridionDocsTopicLink.Models;
using TridionDocsTopicLink.Utility;

namespace TridionDocsTopicLink.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            InfoShareWSHelper infoShareWsHelper = TridionDocsServices.ConnectToTridionDocs();
            //List<Topic> topics = TridionDocsServices.ReadTopicsFromDocs(infoShareWsHelper);
            //return View(topics);
            List<Publication> pubs = TridionDocsServices.ReadPublicationFromDocs(infoShareWsHelper);
            return View(pubs);
        }

        public ActionResult Topics()
        {
            InfoShareWSHelper infoShareWsHelper = TridionDocsServicesForTopic.ConnectToTridionDocs();
            List<Topic> topics = TridionDocsServicesForTopic.ReadTopicsFromDocs(infoShareWsHelper);
            return View(topics);
        }
    }
}