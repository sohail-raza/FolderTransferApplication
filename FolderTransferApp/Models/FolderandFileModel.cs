using Microsoft.Ajax.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Optimization;
using System.Web.UI.WebControls;

namespace FolderTransferApp.Models
{
    public class FolderandFileModel
    {
        [Display(Name = "Source path")]
        public string sourcePath { get; set; }

        [Display(Name = "Target path")]
        public string targetPath { get; set; }

        [Display(Name = "Number of files copied")]
        public int count { get; set; }

        public string fullSourcePath { get; set; }
        public string fullTargetPath { get; set; }

        public string basePath { get; set; }
        public string configPath { get; set; }


        public void CopyFiles(string sourcePath, string targetPath)
        {

            basePath = AppDomain.CurrentDomain.BaseDirectory;
            configPath = @"\Config\FileList.txt";
            string[] files = File.ReadAllLines(basePath+configPath);
            foreach (var file in files)

            {
                fullSourcePath = sourcePath + "\\" + file;
                fullTargetPath = targetPath + "\\" + file;

                if (File.Exists(basePath + configPath) && File.Exists(fullSourcePath))
                  if (!File.Exists(targetPath))
                {

                    File.Copy(fullSourcePath, fullTargetPath, true);
                    count++;
                }
                else
                {
                    continue;
                }

            }
        }


    }





    }