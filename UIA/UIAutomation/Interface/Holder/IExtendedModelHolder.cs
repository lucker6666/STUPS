﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/4/2014
 * Time: 1:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
    using System.Windows.Automation;
    
    /// <summary>
    /// Description of IExtendedModelHolder.
    /// </summary>
    public interface IExtendedModelHolder : IHolder
    {
        void SetScope(TreeScope scope);
        TreeScope GetScope();
        // 20140210
        int Seconds { get; set; }
    }
}
