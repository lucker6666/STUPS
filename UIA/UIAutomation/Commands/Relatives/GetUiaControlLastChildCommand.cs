﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/12/2013
 * Time: 11:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation.Commands
{
    extern alias UIANET;
    using System.Management.Automation;
    using System.Windows.Automation;

    /// <summary>
    /// Description of GetUiaControlLastChildCommand.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "UiaControlLastChild", DefaultParameterSetName = "UiaWildCard")]
    public class GetUiaControlLastChildCommand : GetFamilyCmdletBase //GetRelativesCmdletBase
    {
        /// <summary>
        /// Processes the pipeline.
        /// </summary>
        protected override void ProcessRecord()
        {
            foreach (IUiElement inputObject in InputObject) {
                
                GetAutomationElementsChildren(inputObject, false);
            } // 20120824
            
        }
    }
}
