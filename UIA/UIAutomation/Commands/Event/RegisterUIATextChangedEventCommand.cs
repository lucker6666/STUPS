﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 20/01/2012
 * Time: 09:50 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation.Commands
{
    extern alias UIANET;
    using System.Management.Automation;
    using System.Windows.Automation;
    using UIAutomation.Helpers.Commands;

    /// <summary>
    /// Description of RegisterUiaTextChangedEventCommand.
    /// </summary>
    [Cmdlet(VerbsLifecycle.Register, "UiaTextChangedEvent")]
    
    public class RegisterUiaTextChangedEventCommand : EventCmdletBase
    {
        public RegisterUiaTextChangedEventCommand()
        {
            AutomationEventType = 
                TextPattern.TextChangedEvent;
            AutomationEventHandler = OnUIAutomationEvent;
        }
    }
}
