﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/14/2013
 * Time: 1:20 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
    using System;
    using Castle.DynamicProxy;
    
    /// <summary>
    /// Description of LoggingAspect.
    /// </summary>
    public class LoggingAspect : AbstractInterceptor
    {
        public override void Intercept(IInvocation invocation)
        {
            if (Preferences.Log) {
                try {
                    if (invocation.TargetType.IsSubclassOf(typeof(UiaCommand))) {
                        var cmdlet =
                            (invocation.InvocationTarget as UiaCommand).Cmdlet;
                        var logger =
                            AutomationFactory.GetLogger();
                        logger.LogCmdlet(cmdlet);
                    }
                }
                catch (Exception eLoggingAspect) {
                    // Console.WriteLine(eLoggingAspect.Message);
                }
            }
            
            invocation.Proceed();
        }
    }
}
