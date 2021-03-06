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
	using System;
	using System.Windows.Automation;

	/// <summary>
	/// Description of RangeValuePatternAdapterNet.
	/// </summary>
	public class UiaRangeValuePattern : IRangeValuePattern
	{
		private System.Windows.Automation.RangeValuePattern _rangeValuePattern;
		private IUiElement _element;

		public UiaRangeValuePattern(IUiElement element, RangeValuePattern rangeValuePattern)
		{
			this._rangeValuePattern = rangeValuePattern;
			this._element = element;
			//this._useCache = useCache;
		}

		public UiaRangeValuePattern(IUiElement element)
		{
			this._element = element;
		}

		public struct RangeValuePatternInformation : IRangeValuePatternInformation
		{
			// private AutomationElement _el;
			// private bool _useCache;
			
			private readonly bool _useCache;
			private readonly IRangeValuePattern _rangeValuePattern;

			public RangeValuePatternInformation(IRangeValuePattern rangeValuePattern, bool useCache)
			{
				this._rangeValuePattern = rangeValuePattern;
				this._useCache = useCache;
			}
			
			public double Value {
//				get {
//					object patternPropertyValue = this._el.GetPatternPropertyValue(RangeValuePattern.ValueProperty, this._useCache);
//					if (patternPropertyValue is int) {
//						return (double)((int)patternPropertyValue);
//					}
//					if (patternPropertyValue is int) {
//						return (double)((int)patternPropertyValue);
//					}
//					if (patternPropertyValue is byte) {
//						return (double)((byte)patternPropertyValue);
//					}
//					if (patternPropertyValue is DateTime) {
//						return (double)((DateTime)patternPropertyValue).Year;
//					}
//					return (double)patternPropertyValue;
//				}
			    get { return (double)this._rangeValuePattern.GetParentElement().GetPatternPropertyValue(RangeValuePattern.ValueProperty, this._useCache); }
			}
			public bool IsReadOnly {
				// get { return (bool)this._el.GetPatternPropertyValue(RangeValuePattern.IsReadOnlyProperty, this._useCache); }
				get { return (bool)this._rangeValuePattern.GetParentElement().GetPatternPropertyValue(RangeValuePattern.IsReadOnlyProperty, this._useCache); }
			}
			public double Maximum {
//				get {
//					object patternPropertyValue = this._el.GetPatternPropertyValue(RangeValuePattern.MaximumProperty, this._useCache);
//					if (patternPropertyValue is int) {
//						return (double)((int)patternPropertyValue);
//					}
//					if (patternPropertyValue is int) {
//						return (double)((int)patternPropertyValue);
//					}
//					if (patternPropertyValue is byte) {
//						return (double)((byte)patternPropertyValue);
//					}
//					if (patternPropertyValue is DateTime) {
//						return (double)((DateTime)patternPropertyValue).Year;
//					}
//					return (double)patternPropertyValue;
//				}
			    get { return (double)this._rangeValuePattern.GetParentElement().GetPatternPropertyValue(RangeValuePattern.MaximumProperty, this._useCache); }
			}
			public double Minimum {
//				get {
//					object patternPropertyValue = this._el.GetPatternPropertyValue(RangeValuePattern.MinimumProperty, this._useCache);
//					if (patternPropertyValue is int) {
//						return (double)((int)patternPropertyValue);
//					}
//					if (patternPropertyValue is int) {
//						return (double)((int)patternPropertyValue);
//					}
//					if (patternPropertyValue is byte) {
//						return (double)((byte)patternPropertyValue);
//					}
//					if (patternPropertyValue is DateTime) {
//						return (double)((DateTime)patternPropertyValue).Year;
//					}
//					return (double)patternPropertyValue;
//				}
			    get { return (double)this._rangeValuePattern.GetParentElement().GetPatternPropertyValue(RangeValuePattern.MinimumProperty, this._useCache); }
			}
			public double LargeChange {
//				get {
//					object patternPropertyValue = this._el.GetPatternPropertyValue(RangeValuePattern.LargeChangeProperty, this._useCache);
//					if (patternPropertyValue is int) {
//						return (double)((int)patternPropertyValue);
//					}
//					if (patternPropertyValue is int) {
//						return (double)((int)patternPropertyValue);
//					}
//					if (patternPropertyValue is byte) {
//						return (double)((byte)patternPropertyValue);
//					}
//					if (patternPropertyValue is DateTime) {
//						return (double)((DateTime)patternPropertyValue).Year;
//					}
//					return (double)patternPropertyValue;
//				}
			    get { return (double)this._rangeValuePattern.GetParentElement().GetPatternPropertyValue(RangeValuePattern.LargeChangeProperty, this._useCache); }
			}
			public double SmallChange {
//				get {
//					object patternPropertyValue = this._el.GetPatternPropertyValue(RangeValuePattern.SmallChangeProperty, this._useCache);
//					if (patternPropertyValue is int) {
//						return (double)((int)patternPropertyValue);
//					}
//					if (patternPropertyValue is int) {
//						return (double)((int)patternPropertyValue);
//					}
//					if (patternPropertyValue is byte) {
//						return (double)((byte)patternPropertyValue);
//					}
//					if (patternPropertyValue is DateTime) {
//						return (double)((DateTime)patternPropertyValue).Year;
//					}
//					return (double)patternPropertyValue;
//				}
			    get { return (double)this._rangeValuePattern.GetParentElement().GetPatternPropertyValue(RangeValuePattern.SmallChangeProperty, this._useCache); }
			}
//			internal RangeValuePatternInformation(AutomationElement el, bool useCache)
//			{
//				this._el = el;
//				this._useCache = useCache;
//			}
		}
		public static readonly AutomationPattern Pattern = RangeValuePatternIdentifiers.Pattern;
		public static readonly AutomationProperty ValueProperty = RangeValuePatternIdentifiers.ValueProperty;
		public static readonly AutomationProperty IsReadOnlyProperty = RangeValuePatternIdentifiers.IsReadOnlyProperty;
		public static readonly AutomationProperty MinimumProperty = RangeValuePatternIdentifiers.MinimumProperty;
		public static readonly AutomationProperty MaximumProperty = RangeValuePatternIdentifiers.MaximumProperty;
		public static readonly AutomationProperty LargeChangeProperty = RangeValuePatternIdentifiers.LargeChangeProperty;
		public static readonly AutomationProperty SmallChangeProperty = RangeValuePatternIdentifiers.SmallChangeProperty;
		// private SafePatternHandle _hPattern;
		// private bool _cached;
		
		public virtual IRangeValuePatternInformation Cached {
			get {
				// Misc.ValidateCached(this._cached);
				// return new RangeValuePattern.RangeValuePatternInformation(this._el, true);
				return new UiaRangeValuePattern.RangeValuePatternInformation(this, true);
			}
		}
		
		public virtual IRangeValuePatternInformation Current {
			get {
				// Misc.ValidateCurrent(this._hPattern);
				// return new RangeValuePattern.RangeValuePatternInformation(this._el, false);
				return new UiaRangeValuePattern.RangeValuePatternInformation(this, false);
			}
		}
//		private UiaRangeValuePattern(AutomationElement el, SafePatternHandle hPattern, bool cached) : base(el, hPattern)
//		{
//			this._hPattern = hPattern;
//			this._cached = cached;
//		}
		public virtual void SetValue(double value)
		{
//			object currentPropertyValue = this._el.GetCurrentPropertyValue(AutomationElementIdentifiers.IsEnabledProperty);
//			if (currentPropertyValue is bool && !(bool)currentPropertyValue) {
//				throw new ElementNotEnabledException();
//			}
//			object currentPropertyValue2 = this._el.GetCurrentPropertyValue(RangeValuePattern.IsReadOnlyProperty);
//			if (currentPropertyValue2 is bool && (bool)currentPropertyValue2) {
//				throw new InvalidOperationException(SR.Get("ValueReadonly"));
//			}
//			UiaCoreApi.RangeValuePattern_SetValue(this._hPattern, value);
			this._rangeValuePattern.SetValue(value);
		}
//		static internal object Wrap(AutomationElement el, SafePatternHandle hPattern, bool cached)
//		{
//			return new RangeValuePattern(el, hPattern, cached);
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
		    this._rangeValuePattern = pattern as RangeValuePattern;
		}
		
		public object GetSourcePattern()
		{
		    return this._rangeValuePattern;
		}
	}
}

