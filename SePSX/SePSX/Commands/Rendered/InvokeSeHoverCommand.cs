﻿///*
// * Created by SharpDevelop.
// * User: Alexander Petrovskiy
// * Date: 2012-08-03
// * Time: 21:34
// * 
// * To change this template use Tools | Options | Coding | Edit Standard Headers.
// */
//
//namespace SePSX.Commands
//{
//    using System;
//    using System.Management.Automation;
//    using OpenQA.Selenium;
//    //using OpenQA.Selenium.
//    
//    
//    using OpenQA.Selenium.Remote;
//    
//    
//    /// <summary>
//    /// Description of InvokeSeWebElementHoverOverCommand.
//    /// </summary>
//    [Cmdlet(VerbsLifecycle.Invoke, "SeWebElementHoverOver")]
//    [OutputType(typeof(object))]
//    //public class InvokeSeWebElementHoverOverCommand : RenderedCmdletBase
//    internal class InvokeSeWebElementHoverOverCommand : RenderedCmdletBase
//    {
//        public InvokeSeWebElementHoverOverCommand()
//        {
//        }
//        
//        protected override void ProcessRecord()
//        {
//            this.checkInputWebElementOnly(this.InputObject);
//            
////            try {
////                //WriteObject(this, ((IWebElement)this.InputObject).Size);
////                //((RenderedWebElement)this.InputObject)
////                //RenderedWebElemen
////                //var elt = (RenderedRemoteWebElement)this.InputObject;
////                var elt = (RemoteWebElement)this.InputObject;
////                //elt.h
////                ((OpenQA.Selenium.Support.UI.)this.InputObject)
////            }
////            catch {
////                string errorMessage = 
////                    "The Size property is not available";
////                ErrorRecord err = 
////                    new ErrorRecord(
////                        new Exception(errorMessage),
////                        "SizeFailed",
////                        ErrorCategory.InvalidArgument,
////                        this.InputObject);
////                err.ErrorDetails = 
////                    new ErrorDetails(errorMessage);
////            }
//        }
//    }
//}
