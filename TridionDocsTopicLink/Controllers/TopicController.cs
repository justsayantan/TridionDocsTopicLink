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
    public class TopicController : Controller
    {
        public ActionResult Index()
        {
            InfoShareWSHelper infoShareWsHelper = TridionDocsServicesForTopic.ConnectToTridionDocs();
            List<Topic> topics = TridionDocsServicesForTopic.ReadTopicsFromDocs(infoShareWsHelper);
            return View(topics);
        }        
    }
}