﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 10/2/2012
 * Time: 7:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TAMS
{
    using System;
    using System.Management.Automation;
    using PSTestLib;
    using System.Collections.ObjectModel;
    using System.Collections;
    
    /// <summary>
    /// Description of CommonCmdletBase.
    /// </summary>
    public class CommonCmdletBase : PSCmdletBase
    {
        protected override void WriteLog(LogLevels logLevel, string logRecord)
        {
            if (Preferences.AutoLog) {
                
                switch (logLevel) {
                    case LogLevels.Fatal:
                        TMX.Logger.Fatal(logRecord);
                        break;
                    case LogLevels.Error:
                        TMX.Logger.Error(logRecord);
                        break;
                    case LogLevels.Warn:
                        TMX.Logger.Warn(logRecord);
                        break;
                    case LogLevels.Info:
                        TMX.Logger.Info(logRecord);
                        break;
                    case LogLevels.Debug:
                        TMX.Logger.Debug(logRecord);
                        break;
                    case LogLevels.Trace:
                        TMX.Logger.Trace(logRecord);
                        break;
                }
            }
        }
        
        protected void WriteLog(LogLevels logLevel, System.Management.Automation.ErrorRecord errorRecord)
        {
            if (Preferences.AutoLog) {
                
                this.WriteLog(logLevel, errorRecord.Exception.Message);
                this.WriteLog(logLevel, "Script: '" + errorRecord.InvocationInfo.ScriptName + "', line: " + errorRecord.InvocationInfo.Line.ToString());
            }
        }
        
        protected override bool CheckSingleObject(PSCmdletBase cmdlet, object outputObject) { return true; }
        protected override void BeforeWriteCollection(PSCmdletBase cmdlet, object[] outputObjectCollection) {}
        protected override void BeforeWriteCollection(PSCmdletBase cmdlet, System.Collections.Generic.List<object> outputObjectCollection) {}
        protected override void BeforeWriteCollection(PSCmdletBase cmdlet, ArrayList outputObjectCollection) {}
        protected override void BeforeWriteCollection(PSCmdletBase cmdlet, IList outputObjectCollection) {}
        protected override void BeforeWriteCollection(PSCmdletBase cmdlet, IEnumerable outputObjectCollection) {}
        protected override void BeforeWriteCollection(PSCmdletBase cmdlet, ICollection outputObjectCollection) {}
        protected override void BeforeWriteCollection(PSCmdletBase cmdlet, Hashtable outputObjectCollection) {}
        protected override void BeforeWriteSingleObject(PSCmdletBase cmdlet, object outputObject) {}

        protected override void WriteSingleObject(PSCmdletBase cmdlet, object outputObject)
        {
            //WriteVerbose(this, " TAMS");
            try {
                base.WriteObject(outputObject);
                
                if (Preferences.AutoLog) {
                    
                    string reportString =
                        CmdletSignature(((CommonCmdletBase)cmdlet));
                    
                    reportString +=
                        outputObject.ToString();
                    
                    this.WriteLog(LogLevels.Info, reportString);
                }
            }
            catch {}
        }
        
        protected override void AfterWriteSingleObject(PSCmdletBase cmdlet, object outputObject) {}
        protected override void AfterWriteCollection(PSCmdletBase cmdlet, object[] outputObjectCollection) {}
        protected override void AfterWriteCollection(PSCmdletBase cmdlet, System.Collections.Generic.List<object> outputObjectCollection) {}
        protected override void AfterWriteCollection(PSCmdletBase cmdlet, ArrayList outputObjectCollection) {}
        protected override void AfterWriteCollection(PSCmdletBase cmdlet, IList outputObjectCollection) {}
        protected override void AfterWriteCollection(PSCmdletBase cmdlet, IEnumerable outputObjectCollection) {}
        protected override void AfterWriteCollection(PSCmdletBase cmdlet, ICollection outputObjectCollection) {}
        protected override void AfterWriteCollection(PSCmdletBase cmdlet, Hashtable outputObjectCollection) {}
        
        // 20131114
        protected override void WriteSingleError(PSCmdletBase cmdlet, ErrorRecord errorRecord, bool terminating)
        {
            WriteErrorMethod010RunScriptBlocks(cmdlet);
            
            WriteErrorMethod020SetTestResult(cmdlet, errorRecord);
            
            WriteErrorMethod030ChangeTimeoutSettings(cmdlet, terminating);
            
            WriteErrorMethod040AddErrorToErrorList(cmdlet, errorRecord);
            
            WriteErrorMethod045OnErrorScreenshot(cmdlet);
            
            WriteErrorMethod050OnErrorDelay(cmdlet);
            
            WriteErrorMethod060OutputError(cmdlet, errorRecord, terminating);
            
            WriteErrorMethod070Report(cmdlet);
        }
        
        protected override void WriteErrorMethod010RunScriptBlocks(PSCmdletBase cmdlet)
        {
            
        }
        
        protected override void WriteErrorMethod020SetTestResult(PSCmdletBase cmdlet, ErrorRecord errorRecord)
        {
            
        }
        
        protected override void WriteErrorMethod030ChangeTimeoutSettings(PSCmdletBase cmdlet, bool terminating)
        {
            
        }
        
        protected override void WriteErrorMethod040AddErrorToErrorList(PSCmdletBase cmdlet, ErrorRecord errorRecord)
        {
            
        }
        
        protected override void WriteErrorMethod045OnErrorScreenshot(PSCmdletBase cmdlet)
        {
            
        }
        
        protected override void WriteErrorMethod050OnErrorDelay(PSCmdletBase cmdlet)
        {
            
        }
        
//        protected override void WriteErrorMethod060OutputError(PSCmdletBase cmdlet, ErrorRecord errorRecord, bool terminating)
//        {
//            
//        }
        
        protected override void WriteErrorMethod060OutputError(PSCmdletBase cmdlet, ErrorRecord errorRecord, bool terminating)
        {
            if (terminating) {
                //this.WriteVerbose(this, "terminating error !!!");
                try {
                    
                    // 20130430
                    WriteLog(LogLevels.Fatal, errorRecord);
                    
                    ThrowTerminatingError(errorRecord);
                }
                catch {}
            } else {
                //this.WriteVerbose(this, "regular error !!!");
                try {
                    
                    // 20130430
                    WriteLog(LogLevels.Error, errorRecord);
                    
                    WriteError(errorRecord);
                }
                catch {}
            }
        }
        
        protected override void WriteErrorMethod070Report(PSCmdletBase cmdlet)
        {
//            if (Preferences.AutoLog) {
//                
//                string reportString =
//                    CmdletSignature(((CommonCmdletBase)cmdlet));
//                
//                reportString +=
//                    
//                
//                this.WriteLog(LogLevels.Info, reportString);
//            }
        }
    }
}
