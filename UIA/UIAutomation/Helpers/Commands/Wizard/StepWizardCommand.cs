﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 3/18/2013
 * Time: 2:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
    using System;
    using System.Management.Automation;
    using Commands;
    
    /// <summary>
    /// Description of UiaStepWizardCommand.
    /// </summary>
    public class StepWizardCommand : UiaCommand
    {
        public StepWizardCommand(CommonCmdletBase cmdlet) : base (cmdlet)
        {
        }
        
        public override void Execute()
        {
            StepUiaWizardCommand cmdlet =
                (StepUiaWizardCommand)Cmdlet;
            
            WizardHelper.StepWizardStep(cmdlet);
        }
    }
}
