﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/8/2013
 * Time: 3:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
	extern alias UIANET;
	using System;
	using System.Windows.Automation;

	/// <summary>
	/// Description of ScrollPatternAdapter.
	/// </summary>
	public class UiaScrollPattern : IScrollPattern
	{
		private System.Windows.Automation.ScrollPattern _scrollPattern;
		private IUiElement _element;

		public UiaScrollPattern(IUiElement element, ScrollPattern scrollPattern)
		{
			this._scrollPattern = scrollPattern;
			this._element = element;
			//this._useCache = useCache;
		}

		public UiaScrollPattern(IUiElement element)
		{
			this._element = element;
		}

		// public struct ScrollPatternInformation
		public struct ScrollPatternInformation : IScrollPatternInformation
		{
			// private AutomationElement _el;
			private bool _useCache;
			
			private IScrollPattern _scrollPattern;
			
			public ScrollPatternInformation(IScrollPattern scrollPattern, bool useCache)
			{
			    this._scrollPattern = scrollPattern;
			    this._useCache = useCache;
			}
			
			public double HorizontalScrollPercent {
				// get { return (double)this._el.GetPatternPropertyValue(ScrollPattern.HorizontalScrollPercentProperty, this._useCache); }
				get { return (double)this._scrollPattern.GetParentElement().GetPatternPropertyValue(ScrollPattern.HorizontalScrollPercentProperty, this._useCache); }
			}
			public double VerticalScrollPercent {
				// get { return (double)this._el.GetPatternPropertyValue(ScrollPattern.VerticalScrollPercentProperty, this._useCache); }
				get { return (double)this._scrollPattern.GetParentElement().GetPatternPropertyValue(ScrollPattern.VerticalScrollPercentProperty, this._useCache); }
			}
			public double HorizontalViewSize {
				// get { return (double)this._el.GetPatternPropertyValue(ScrollPattern.HorizontalViewSizeProperty, this._useCache); }
				get { return (double)this._scrollPattern.GetParentElement().GetPatternPropertyValue(ScrollPattern.HorizontalViewSizeProperty, this._useCache); }
			}
			public double VerticalViewSize {
				// get { return (double)this._el.GetPatternPropertyValue(ScrollPattern.VerticalViewSizeProperty, this._useCache); }
				get { return (double)this._scrollPattern.GetParentElement().GetPatternPropertyValue(ScrollPattern.VerticalViewSizeProperty, this._useCache); }
			}
			public bool HorizontallyScrollable {
				// get { return (bool)this._el.GetPatternPropertyValue(ScrollPattern.HorizontallyScrollableProperty, this._useCache); }
				get { return (bool)this._scrollPattern.GetParentElement().GetPatternPropertyValue(ScrollPattern.HorizontallyScrollableProperty, this._useCache); }
			}
			public bool VerticallyScrollable {
				// get { return (bool)this._el.GetPatternPropertyValue(ScrollPattern.VerticallyScrollableProperty, this._useCache); }
				get { return (bool)this._scrollPattern.GetParentElement().GetPatternPropertyValue(ScrollPattern.VerticallyScrollableProperty, this._useCache); }
			}
//			internal ScrollPatternInformation(AutomationElement el, bool useCache)
//			{
//				this._el = el;
//				this._useCache = useCache;
//			}
		}
		public const double NoScroll = -1.0;
		public static readonly AutomationPattern Pattern = ScrollPatternIdentifiers.Pattern;
		public static readonly AutomationProperty HorizontalScrollPercentProperty = ScrollPatternIdentifiers.HorizontalScrollPercentProperty;
		public static readonly AutomationProperty HorizontalViewSizeProperty = ScrollPatternIdentifiers.HorizontalViewSizeProperty;
		public static readonly AutomationProperty VerticalScrollPercentProperty = ScrollPatternIdentifiers.VerticalScrollPercentProperty;
		public static readonly AutomationProperty VerticalViewSizeProperty = ScrollPatternIdentifiers.VerticalViewSizeProperty;
		public static readonly AutomationProperty HorizontallyScrollableProperty = ScrollPatternIdentifiers.HorizontallyScrollableProperty;
		public static readonly AutomationProperty VerticallyScrollableProperty = ScrollPatternIdentifiers.VerticallyScrollableProperty;
		// private SafePatternHandle _hPattern;
		// private bool _cached;
		
		public virtual IScrollPatternInformation Cached {
			get {
				// Misc.ValidateCached(this._cached);
				// return new ScrollPattern.ScrollPatternInformation(this._el, true);
				return new UiaScrollPattern.ScrollPatternInformation(this, true);
			}
		}
		
		public virtual IScrollPatternInformation Current {
			get {
				// Misc.ValidateCurrent(this._hPattern);
				// return new ScrollPattern.ScrollPatternInformation(this._el, false);
				return new UiaScrollPattern.ScrollPatternInformation(this, false);
			}
		}
//		private UiaScrollPattern(AutomationElement el, SafePatternHandle hPattern, bool cached) : base(el, hPattern)
//		{
//			this._hPattern = hPattern;
//			this._cached = cached;
//		}
		public virtual void SetScrollPercent(double horizontalPercent, double verticalPercent)
		{
			// UiaCoreApi.ScrollPattern_SetScrollPercent(this._hPattern, horizontalPercent, verticalPercent);
			this._scrollPattern.SetScrollPercent(horizontalPercent, verticalPercent);
		}
		public virtual void Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount)
		{
			// UiaCoreApi.ScrollPattern_Scroll(this._hPattern, horizontalAmount, verticalAmount);
			this._scrollPattern.Scroll(horizontalAmount, verticalAmount);
		}
		public virtual void ScrollHorizontal(ScrollAmount amount)
		{
			// UiaCoreApi.ScrollPattern_Scroll(this._hPattern, amount, ScrollAmount.NoAmount);
			this._scrollPattern.ScrollHorizontal(amount);
		}
		public virtual void ScrollVertical(ScrollAmount amount)
		{
			// UiaCoreApi.ScrollPattern_Scroll(this._hPattern, ScrollAmount.NoAmount, amount);
			this._scrollPattern.ScrollVertical(amount);
		}
//		static internal object Wrap(AutomationElement el, SafePatternHandle hPattern, bool cached)
//		{
//			return new ScrollPattern(el, hPattern, cached);
//		}
		
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
		    this._scrollPattern = pattern as ScrollPattern;
		}
		
		public object GetSourcePattern()
		{
		    return this._scrollPattern;
		}
	}
}
