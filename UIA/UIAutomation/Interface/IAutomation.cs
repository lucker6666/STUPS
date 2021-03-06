﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/30/2014
 * Time: 5:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
    using System;
    
    using System.Windows.Automation;
    
	public interface IAutomation
	{
		bool Compare(IUiElement el1, IUiElement el2);
		bool Compare(int[] runtimeId1, int[] runtimeId2);
		string PropertyName(AutomationProperty property);
		string PatternName(IBasePattern pattern);
		void AddAutomationEventHandler(AutomationEvent eventId, IUiElement element, TreeScope scope, AutomationEventHandler eventHandler);
		void RemoveAutomationEventHandler(AutomationEvent eventId, IUiElement element, AutomationEventHandler eventHandler);
		void AddAutomationPropertyChangedEventHandler(IUiElement element, TreeScope scope, AutomationPropertyChangedEventHandler eventHandler, params AutomationProperty[] properties);
		void RemoveAutomationPropertyChangedEventHandler(IUiElement element, AutomationPropertyChangedEventHandler eventHandler);
		void AddStructureChangedEventHandler(IUiElement element, TreeScope scope, StructureChangedEventHandler eventHandler);
		void RemoveStructureChangedEventHandler(IUiElement element, StructureChangedEventHandler eventHandler);
		void AddAutomationFocusChangedEventHandler(AutomationFocusChangedEventHandler eventHandler);
		void RemoveAutomationFocusChangedEventHandler(AutomationFocusChangedEventHandler eventHandler);
		void RemoveAllEventHandlers();
		
		Condition RawViewCondition { get; }
		Condition ControlViewCondition { get; }
		Condition ContentViewCondition { get; }
	}
}
