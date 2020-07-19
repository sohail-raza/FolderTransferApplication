using FolderTransferApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FolderTransferApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FolderSelect()
        {

            ViewBag.Message = "The folder selection page.";

            return View();
        }

        [HttpPost]
        public ActionResult FolderSelect(FolderandFileModel model, string sourcePath, string targetPath)
        {


            if (Directory.Exists(sourcePath) && Directory.Exists(targetPath)
                && sourcePath != targetPath)
            {
                model.CopyFiles(sourcePath,targetPath);
                
                return View("CreatedPage",model);
            }

            return View("FolderSelect", model);
        }


        public ActionResult CreatedPage()
        {
            ViewBag.Message = "The test page.";

            return View();
        }

        public ActionResult ReadMe()
        {
            ViewBag.Message = "The README page.";


            return View();
        }

    }
}