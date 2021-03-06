﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/14/2013
 * Time: 1:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
    using System;
    using Castle.DynamicProxy;
    
    /// <summary>
    /// Description of ErrorHandlingAspect.
    /// </summary>
    public class ErrorHandlingAspect : AbstractInterceptor
    {
        public override void Intercept(IInvocation invocation)
        {
            try {
                invocation.Proceed();
            } catch (Exception eOnInvocation) {
                
//                if (Preferences.Log) {
//                    LogHelper.Error(eOnInvocation.Message);
//                }
                
                if (Preferences.Log) {
//                    try {
                        if (invocation.TargetType.IsSubclassOf(typeof(UiaCommand))) {
                            LogHelper.Error(eOnInvocation.Message);
//                            var cmdlet =
//                                (invocation.InvocationTarget as UiaCommand).Cmdlet;
//                            var logger =
//                                AutomationFactory.GetLogger();
//                            logger.LogCmdlet(cmdlet);
                        }
//                    }
//                    catch (Exception eLoggingAspect) {
//                        // Console.WriteLine(eLoggingAspect.Message);
//                    }
                }
                
                Exception eNewException =
                    new Exception("Class " + invocation.TargetType.Name + ", method " + invocation.Method.Name + ": " + eOnInvocation.Message);
                throw eNewException;
            }
            
        }
    }
}
