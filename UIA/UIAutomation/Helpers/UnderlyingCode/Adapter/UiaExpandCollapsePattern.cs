﻿using System.Deployment.Internal;
/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/6/2013
 * Time: 10:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
	extern alias UIANET;
	using System;
	using System.Windows.Automation;

	public class UiaExpandCollapsePattern : IExpandCollapsePattern
	{
		private System.Windows.Automation.ExpandCollapsePattern _expandCollapsePattern;
		private IUiElement _element;
		
		public UiaExpandCollapsePattern(IUiElement element, ExpandCollapsePattern expandCollapsePattern)
		{
			this._expandCollapsePattern = expandCollapsePattern;
			this._element = element;
			//this._useCache = useCache;
		}
		
		public UiaExpandCollapsePattern(IUiElement element)
		{
		    this._element = element;
		}
		
		public UiaExpandCollapsePattern(ExpandCollapsePattern ExpandCollapsePattern)
		{
		    this._expandCollapsePattern = ExpandCollapsePattern;
		}

		public struct ExpandCollapsePatternInformation : IExpandCollapsePatternInformation
		{
			private bool _useCache;
			private IExpandCollapsePattern _expandCollapsePattern;
			
			public ExpandCollapsePatternInformation(IExpandCollapsePattern expandCollapsePattern, bool useCache)
			{
			    this._expandCollapsePattern = expandCollapsePattern;
			    this._useCache = useCache;
			}
			
			public ExpandCollapseState ExpandCollapseState {
				get { return (ExpandCollapseState)this._expandCollapsePattern.GetParentElement().GetPatternPropertyValue(ExpandCollapsePattern.ExpandCollapseStateProperty, this._useCache); }
			}
		}
		public static readonly AutomationPattern Pattern = ExpandCollapsePatternIdentifiers.Pattern;
		public static readonly AutomationProperty ExpandCollapseStateProperty = ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty;
        
		public virtual IExpandCollapsePatternInformation Cached {
			get {
				return new UiaExpandCollapsePattern.ExpandCollapsePatternInformation(this, true);
			}
		}
		
		public virtual IExpandCollapsePatternInformation Current {
			get {
				return new UiaExpandCollapsePattern.ExpandCollapsePatternInformation(this, false);
			}
		}
        
		public virtual void Expand()
		{
			if (null == this._expandCollapsePattern) return;
			this._expandCollapsePattern.Expand();
		}
		public virtual void Collapse()
		{
			if (null == this._expandCollapsePattern) return;
			this._expandCollapsePattern.Collapse();
		}
		
		public void SetParentElement(IUiElement element)
		{
		    this._element = element;
		}
		
		public IUiElement GetParentElement()
		{
		    return this._element;
		}
		
		public void SetSourcePattern(object pattern)
		{
		    this._expandCollapsePattern = pattern as ExpandCollapsePattern;
		}
		
		public object GetSourcePattern()
		{
		    return this._expandCollapsePattern;
		}
	}
}
