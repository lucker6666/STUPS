﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 07/12/2011
 * Time: 11:42 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomationTest.Commands.Common
{
    using System;
    using MbUnit.Framework;//using MbUnit.Framework; // using MbUnit.Framework;
    using System.Management.Automation;

    /// <summary>
    /// Description of SetUiaFocusCommandTextFixture.
    /// </summary>
    [TestFixture] // [TestFixture(Description="Set-UiaFocusCommand test")]
    public class SetUiaFocusCommandTestFixture
    {
        [SetUp]
        public void PrepareRunspace()
        {
            MiddleLevelCode.PrepareRunspace();
        }
        
        [Test] //[Test(Description="InputObject ProcessRecord test Null via pipeline")]
        [Category("Slow")]
        [Category("NoForms")]
        public void SetUiaFocus_TestPipelineInput()
        {
            CmdletUnitTest.TestRunspace.RunAndEvaluateIsTrue(
                @"if ( ($null | Set-UiaFocus) ) { 1; } else { 0; }",
                "0");
        }
        
        [Test] //[Test(Description="ProcessRecord test Null via parameter")]
        [Category("Slow")]
        [Category("NoForms")]
        public void SetUiaFocus_TestParameterInputNull()
        {
//            CmdletUnitTest.TestRunspace.RunAndEvaluateIsNull(
//                @"if ((Set-UiaFocus -InputObject $null)) { 1; } else { 0; }");
            
            CmdletUnitTest.TestRunspace.RunAndGetTheException(
                @"if ((Set-UiaFocus -InputObject $null)) { 1; } else { 0; }",
                "ParameterBindingValidationException",
                @"Cannot validate argument on parameter 'InputObject'. The argument is null or empty. Supply an argument that is not null or empty and then try the command again.");
            
//            UIAutomationTest.Commands.Common.SetUiaFocusCommandTestFixture.TestParameterInputNull:
//System.Management.Automation.ParameterBindingValidationException : Cannot validate argument on parameter 'InputObject'. The argument is null or empty. Supply an argument that is not null or empty and then try the command again.
//  ----> System.Management.Automation.ValidationMetadataException : The argument is null or empty. Supply an argument that is not null or empty and then try the command again.
        }
        
        [Test] //[Test(Description="ProcessRecord test Is Not AutomationElement")]
        [Category("Slow")]
        [Category("NoForms")]
        public void SetUiaFocus_TestParameterInputOtherType()
        {
//            CmdletUnitTest.TestRunspace.RunAndEvaluateIsNull(
//                @"if ((Set-UiaFocus -InputObject (New-Object System.Windows.forms.Label))) { 1; } else { 0; }");
            
            CmdletUnitTest.TestRunspace.RunAndGetTheException(
                @"if ((Set-UiaFocus -InputObject (New-Object System.Windows.forms.Label))) { 1; } else { 0; }",
                "ParameterBindingException", 
                //@"Cannot bind parameter 'InputObject'. Cannot convert the ""System.Windows.Forms.Label, Text: "" value of type ""System.Windows.Forms.Label"" to type ""System.Windows.Automation.AutomationElement"".");
                @"Cannot bind parameter 'InputObject'. Cannot convert the ""System.Windows.Forms.Label, Text: "" value of type ""System.Windows.Forms.Label"" to type ""UIAutomation.IUiElement"".");
            
//            UIAutomationTest.Commands.Common.SetUiaFocusCommandTestFixture.TestParameterInputOtherType:
//System.Management.Automation.ParameterBindingException : Cannot bind parameter 'InputObject'. Cannot convert the "System.Windows.Forms.Label, Text: " value of type "System.Windows.Forms.Label" to type "System.Windows.Automation.AutomationElement".
//  ----> System.Management.Automation.PSInvalidCastException : Cannot convert the "System.Windows.Forms.Label, Text: " value of type "System.Windows.Forms.Label" to type "System.Windows.Automation.AutomationElement".
        }
        
        [TearDown]
        public void DisposeRunspace()
        {
            MiddleLevelCode.DisposeRunspace();
        }
        
    }
}
