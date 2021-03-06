﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 4/1/2013
 * Time: 3:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TMX
{
    using System;
    using System.Management.Automation;
    using TMX.Commands;
    
    /// <summary>
    /// Description of TmxGetTestResultDetailsCommand.
    /// </summary>
    internal class TmxGetTestResultDetailsCommand : TmxCommand
    {
        internal TmxGetTestResultDetailsCommand(CommonCmdletBase cmdlet) : base (cmdlet)
        {
        }
        
        internal override void Execute()
        {
            GetTmxTestResultDetailsCommand cmdlet =
                (GetTmxTestResultDetailsCommand)this.Cmdlet;
            
            TmxHelper.GetTestResultDetails(cmdlet);
        }
    }
}
