﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 17.02.2012
 * Time: 13:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TMX.Commands
{
    using System;
    using System.Management.Automation;
    
    /// <summary>
    /// Description of ExportTmxTestResultsCommand.
    /// </summary>
    [Cmdlet(VerbsData.Export, "TmxTestResults")]
    public class ExportTmxTestResultsCommand : ImportExportCmdletBase //ExportCmdletBase //CmdletBase
    {
        public ExportTmxTestResultsCommand()
        {
            //this.Name = string.Empty;
        }
        
        #region Parameters
//        [Parameter(Mandatory = true)]
//        public string As { get; set; }
//        
//        [Parameter(Mandatory = false)]
//        public string Path { get; set; }
//        
//        [Parameter(Mandatory = false)]
//        internal new string Name { get; set; }
        
//        [Parameter(Mandatory = false,
//                   ValueFromPipeline = true)]
//        public 
        #endregion Parameters
        
        protected override void BeginProcessing()
        {
            this.CheckCmdletParameters();
            
            this.WriteVerbose(this, "As = " + this.As);
            this.WriteVerbose(this, "Path = " + this.Path);
            
            string reportFormat = this.As.ToUpper();
            switch (reportFormat){
                case "XML":
                    TmxHelper.ExportResultsToXML(this, this.Path);
                    break;
                case "JUNIT":
                case "JUNITXML":
                    TmxHelper.ExportResultsToJUnitXML(this, this.Path);
                    break;
                case "HTML":
                    // 20130322
                    //this.ExportResultsToHTML(this.Path);
                    this.ExportResultsToHTML(this, this.Path);
                    break;
                case "CSV":
                    this.ExportResultsToCSV(this.Path);
                    break;
                case "TEXT":
                    this.ExportResultsToTEXT(this.Path);
                    break;
                case "ZIP":
                    this.ExportResultsToZIP(this.Path);
                    break;
                default:
                    
                    break;
            }
            
        }
    }
}
