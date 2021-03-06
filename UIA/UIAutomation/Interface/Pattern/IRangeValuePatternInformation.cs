﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/8/2013
 * Time: 10:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
	extern alias UIANET;
	using System.Windows.Automation;
	
	public interface IRangeValuePatternInformation
	{
		double Value { get; }
		bool IsReadOnly { get; }
		double Maximum { get; }
		double Minimum { get; }
		double LargeChange { get; }
		double SmallChange { get; }
	}
}

