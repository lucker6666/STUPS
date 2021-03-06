﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/23/2014
 * Time: 6:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace TestUtils
{
    using System;
    using System.Management.Automation;
    using TestUtils.Commands;
    
    /// <summary>
    /// Description of TuExpandRarArchiveCommand.
    /// </summary>
    internal class TuExpandRarArchiveCommand : Win32Command
    {
        internal TuExpandRarArchiveCommand(CommonCmdletBase cmdlet) : base (cmdlet)
        {
        }
        
        internal override void Execute()
        {
            ExpandTuRarArchiveCommand cmdlet =
                (ExpandTuRarArchiveCommand)this.Cmdlet;
            
            ArchivingHelper.ExtractFromRarArchive(cmdlet);
        }
    }
}
