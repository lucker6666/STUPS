﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/4/2013
 * Time: 10:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomation
{
    extern alias UIANET;
    using System;
    using System.Windows.Automation;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;
    using PSTestLib;
    
    using System.Globalization;
    using System.Threading;
    using System.Windows.Forms;
    using System.Text.RegularExpressions;
    
    /// <summary>
    /// Description of ExtensionMethodsElement.
    /// </summary>
    public static class ExtensionMethodsElement
    {
        public static IUiElement GetParent(this IUiElement element)
        {
            IUiElement result = null;
            
            TreeWalker walker =
                new TreeWalker(
                    System.Windows.Automation.Condition.TrueCondition);
            
            try {
                result = AutomationFactory.GetUiElement(walker.GetParent(element.GetSourceElement() as AutomationElement));
            }
            catch {}
            
            return result;
        }
        
        #region get an ancestor with a handle
        /// <summary>
        ///  /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        internal static IUiElement GetAncestorWithHandle(this IUiElement element)
        {
            TreeWalker walker =
                new TreeWalker(
                    System.Windows.Automation.Condition.TrueCondition);
            
            try {
                
                // 20140102
                // IUiElement testparent = AutomationFactory.GetUiElement(walker.GetParent(element.GetSourceElement()));
                IUiElement testparent = AutomationFactory.GetUiElement(walker.GetParent(element.GetSourceElement() as AutomationElement));
                while (testparent != null &&
                       testparent.Current.NativeWindowHandle == 0) {
                    testparent =
                        // 20140102
                        // AutomationFactory.GetUiElement(walker.GetParent(testparent.GetSourceElement()));
                        AutomationFactory.GetUiElement(walker.GetParent(testparent.GetSourceElement() as AutomationElement));
                    if (testparent != null &&
                        (int)testparent.Current.ProcessId > 0 &&
                        testparent.Current.NativeWindowHandle != 0) {
                        
                        return testparent;
                    }
                }
                return testparent.Current.NativeWindowHandle != 0 ? testparent : null;
                
            } catch {
                return null;
            }
        }
        #endregion get an ancestor with a handle
        
        #region get the parent or an ancestor
        /// <summary>
        ///  /// </summary>
        /// <param name="element"></param>
        /// <param name="scope"></param>
        /// <returns></returns>
        internal static IUiElement[] GetParentOrAncestor(this IUiElement element, TreeScope scope)
        {
            TreeWalker walker =
                new TreeWalker(
                    System.Windows.Automation.Condition.TrueCondition);
            
            List<IUiElement> ancestors =
                new List<IUiElement>();
            
            try {
                
                // 20140102
                // IUiElement testParent = AutomationFactory.GetUiElement(walker.GetParent(element.GetSourceElement()));
                IUiElement testParent = AutomationFactory.GetUiElement(walker.GetParent(element.GetSourceElement() as AutomationElement));
                    
                if (scope == TreeScope.Parent || scope == TreeScope.Ancestors) {
                    
                    // 20131226
                    // if (testParent != UiElement.RootElement) {
                    if (testParent.Current != UiElement.RootElement.Current) {
                        ancestors.Add(testParent);
                    }
                    
                    // 20131226
                    // if (testParent == UiElement.RootElement ||
                    if ((testParent.Equals(UiElement.RootElement) && testParent.Current.Equals(UiElement.RootElement.Current)) ||
                        scope == TreeScope.Parent) {
                        return ancestors.ToArray();
                    }
                }
                while (testParent != null &&
                       (int)testParent.Current.ProcessId > 0 &&
                       // 20131226
                       // testParent != UiElement.RootElement) {
                       !testParent.Current.Equals(UiElement.RootElement.Current)) {
                    
                    testParent =
                        // 20140102
                        // AutomationFactory.GetUiElement(walker.GetParent(testParent.GetSourceElement()));
                        AutomationFactory.GetUiElement(walker.GetParent(testParent.GetSourceElement() as AutomationElement));
                    if (testParent != null &&
                        (int)testParent.Current.ProcessId > 0 &&
                        // 20131226
                        // testParent != UiElement.RootElement) {
                        // !testParent.Equals(UiElement.RootElement)) {
                        !testParent.Current.Equals(UiElement.RootElement.Current)) {
                        
                        ancestors.Add(testParent);
                    } else {
                        break;
                    }
                }
                return ancestors.ToArray();
            } catch {
                return ancestors.ToArray();
            }
        }
        #endregion get the parent or an ancestor
        
        #region Collect ancestors
        /// <summary>
        ///
        /// </summary>
        /// <param name="cmdlet"></param>
        /// <param name="element"></param>
        internal static void CollectAncestors(this IUiElement element, TranscriptCmdletBase cmdlet, ref string errorMessage, ref bool errorOccured)
        {
            TreeWalker walker =
                new TreeWalker(
                    System.Windows.Automation.Condition.TrueCondition);
            
            try
            {
                // commented out 201206210
                //testparent =
                //    walker.GetParent(element);
                IUiElement testParent = element;

                while (testParent != null && (int)testParent.Current.ProcessId > 0) {
                    
                    testParent =
                        // 20140102
                        // AutomationFactory.GetUiElement(walker.GetParent(testParent.GetSourceElement()));
                        AutomationFactory.GetUiElement(walker.GetParent(testParent.GetSourceElement() as AutomationElement));
                    
                    if (testParent == null || (int) testParent.Current.ProcessId <= 0) continue;
                    if (testParent == cmdlet.OddRootElement)
                    { testParent = null; }
                    else{
                        string parentControlType =
                            // getControlTypeNameOfAutomationElement(testparent, element);
                            // testparent.Current.ControlType.ProgrammaticName.Substring(
                            // element.Current.ControlType.ProgrammaticName.IndexOf('.') + 1);
                            //  // experimental
                            testParent.Current.ControlType.ProgrammaticName.Substring(
                                testParent.Current.ControlType.ProgrammaticName.IndexOf('.') + 1);
                        //  // if (parentControlType.Length == 0) {
                        // break;
                        //}
                            
                        // in case this element is an upper-level Pane
                        // residing directrly under the RootElement
                        // change type to window
                        // i.e. Get-UiaPane - >  Get-UiaWindow
                        // since Get-UiaPane is unable to get something more than
                        // a window's child pane control
                        if (parentControlType == "Pane" || parentControlType == "Menu") {
                            
                            // 20131109
                            //if (walker.GetParent(testParent) == cmdlet.rootElement) {
                            // 20131112
                            //if ((new UiElement(walker.GetParent(testParent.SourceElement))) == cmdlet.oddRootElement) {
                            // 20131118
                            // property to method
                            //if (ObjectsFactory.GetUiElement(walker.GetParent(testParent.SourceElement)) == cmdlet.oddRootElement) {
                            // 20140102
                            // if (AutomationFactory.GetUiElement(walker.GetParent(testParent.GetSourceElement())) == cmdlet.OddRootElement) {
                            if (AutomationFactory.GetUiElement(walker.GetParent(testParent.GetSourceElement() as AutomationElement)) == cmdlet.OddRootElement) {
                                parentControlType = "Window";
                            }
                        }
                            
                        string parentVerbosity =
                            @"Get-Uia" + parentControlType;
                        try {
                            if (testParent.Current.AutomationId.Length > 0) {
                                parentVerbosity += (" -AutomationId '" + testParent.Current.AutomationId + "'");
                            }
                        }
                        catch {
                        }
                        if (!cmdlet.NoClassInformation) {
                            try {
                                if (testParent.Current.ClassName.Length > 0) {
                                    parentVerbosity += (" -Class '" + testParent.Current.ClassName + "'");
                                }
                            }
                            catch {
                            }
                        }
                        try {
                            if (testParent.Current.Name.Length > 0) {
                                parentVerbosity += (" -Name '" + testParent.Current.Name + "'");
                            }
                        }
                        catch {
                        }

                        if (cmdlet.LastRecordedItem[cmdlet.LastRecordedItem.Count - 1].ToString() == parentVerbosity)
                            continue;
                        cmdlet.LastRecordedItem.Add(parentVerbosity);
                        cmdlet.WriteVerbose(parentVerbosity);
                    }
                }
            }
            catch (Exception eErrorInTheInnerCycle) {
                cmdlet.WriteDebug(cmdlet, eErrorInTheInnerCycle.Message);
                // _errorMessageInTheInnerCycle =
                errorMessage =
                    eErrorInTheInnerCycle.Message;
                // _errorInTheInnerCycle = true;
                errorOccured = true;
            }
        }
        #endregion Collect ancestors
        
        /// <summary>
        /// Retrievs an element's ControlType property as a string.
        /// </summary>
        /// <param name="element">AutomationElement</param>
        /// <returns>string</returns>
        internal static string GetElementControlTypeString(this IUiElement element)
        {
            string elementControlType = String.Empty;
            try {
                elementControlType = element.Current.ControlType.ProgrammaticName;
            } catch {
                elementControlType = element.Cached.ControlType.ProgrammaticName;
            }
            if (string.Empty != elementControlType && 0 < elementControlType.Length) {
                elementControlType = elementControlType.Substring(elementControlType.IndexOf('.') + 1);
            }
            //string elementVerbosity = String.Empty;
            //if (string.Empty == elementControlType || 0 == elementControlType.Length) {
            //    return result;
            //}
            return elementControlType;
        }
        
        /// <summary>
        /// Retrieves such element's properties as AutomationId, Name, Class(Name) and Value
        /// </summary>
        /// <param name="cmdlet">cmdlet to report</param>
        /// <param name="element">The element properties taken from</param>
        /// <param name="propertyName">The name of property</param>
        /// <param name="pattern">an object of the ValuePattern type</param>
        /// <param name="hasName">an object has Name</param>
        /// <returns></returns>
        internal static string GetElementPropertyString(
            this IUiElement element,
            PSCmdletBase cmdlet,
            string propertyName,
            IValuePattern pattern,
            ref bool hasName)
        {
            string tempString = string.Empty;
            try {
                
                switch (propertyName) {
                    case "Name":
                        if (!string.IsNullOrEmpty(element.Current.Name)) {
                            tempString = element.Current.Name;
                            hasName = true;
                        }
                        break;
                    case "AutomationId":
                        if (!string.IsNullOrEmpty(element.Current.AutomationId)) {
                            tempString = element.Current.AutomationId;
                        }
                        break;
                    case "Class":
                        if (!string.IsNullOrEmpty(element.Current.ClassName)) {
                            tempString = element.Current.ClassName;
                        }
                        break;
                    case "Value":
                        try {
                            if (!string.IsNullOrEmpty(pattern.Current.Value)) {
                                tempString = pattern.Current.Value;
                                hasName = true;
                            }
                        }
                        catch {}
                        break;
                    case "Win32":
                        if (0 < element.Current.NativeWindowHandle) {
                            tempString = ".";
                        }
                        break;
                    default:
                        
                    	break;
                }
            } catch {
                switch (propertyName) {
                    case "Name":
                        if (!string.IsNullOrEmpty(element.Cached.Name)) {
                            tempString = element.Cached.Name;
                            hasName = true;
                        }
                        break;
                    case "AutomationId":
                        if (!string.IsNullOrEmpty(element.Cached.AutomationId)) {
                            tempString = element.Cached.AutomationId;
                        }
                        break;
                    case "Class":
                        if (!string.IsNullOrEmpty(element.Cached.ClassName)) {
                            tempString = element.Cached.ClassName;
                        }
                        break;
                    case "Value":
                        try {
                            if (!string.IsNullOrEmpty(pattern.Cached.Value)) {
                                tempString = pattern.Cached.Value;
                                hasName = true;
                            }
                        }
                        catch {}
                        break;
                    case "Win32":
                        if (0 < element.Cached.NativeWindowHandle) {
                            tempString = ".";
                        }
                        break;
                    default:
                        
                    	break;
                }
            }
            if (string.IsNullOrEmpty(tempString)) {
                return string.Empty;
            } else {
                if ("Win32" == propertyName) {
                    tempString =
                        " -" + propertyName;
                } else {
                    tempString =
                        " -" + propertyName + " '" + tempString + "'";
                }
                return tempString;
            }
        }
        // 20140218
//        internal static List<IntPtr> GetControlByNameViaWin32Recursively(
//            this IUiElement containerElement,
//            string name,
//            int level)
//        {
//            var resultHandle = IntPtr.Zero;
//            var controlHandle = IntPtr.Zero;
//            var controlHandles = new List<IntPtr>();
//            var tempControlHandles = new List<IntPtr>();
//            var containerHandle = new IntPtr(containerElement.Current.NativeWindowHandle);
//            
//            if (containerHandle == IntPtr.Zero) return controlHandles;
//            
//            // search at this level
//            do {
//                // using null instead of name
//                controlHandle =
//                    NativeMethods.FindWindowEx(containerHandle, controlHandle, null, null);
//                
//                if (controlHandle == IntPtr.Zero) continue;
//                controlHandles.Add(controlHandle);
//                
//                tempControlHandles =
//                    UiElement.FromHandle(controlHandle).GetControlByNameViaWin32Recursively(
//                        name,
//                        level + 1);
//                
//                if (null == tempControlHandles || 0 == tempControlHandles.Count) continue;
//                controlHandles.AddRange(tempControlHandles);
//                
//            } while (controlHandle != IntPtr.Zero);
//            
//            return controlHandles;
//        }
        
        internal static bool IsMatchWildcardPattern(
            this IUiElement elementInput,
            IList resultCollection,
            WildcardPattern wcPattern,
            string dataToCheck)
        {
            bool result = false;
            
            if (string.IsNullOrEmpty(dataToCheck)) {
                return result;
            }
            
            if (!wcPattern.IsMatch(dataToCheck)) return result;
            
            result = true;
            resultCollection.Add(elementInput);
            return result;
        }
        
        internal static IUiElement InvokeContextMenu(this IUiElement inputObject, HasControlInputCmdletBase cmdlet, int x, int y)
        // internal static IUiElement InvokeContextMenu(this IUiElement inputObject, int x, int y)
        {
            IUiElement resultElement = null;
            try {
                
                if (!cmdlet.ClickControl(
                        cmdlet,
                        inputObject,
                        new ClickSettings() {
                            RightClick = true,
                            RelativeX = (x < 0 ? Preferences.ClickOnControlByCoordX : x),
                            RelativeY = (y < 0 ? Preferences.ClickOnControlByCoordY : y)
                        })) {
                }
            }
            catch (Exception eClickONControl) {
                throw new Exception("failed to click on the control");
            }
            
            // 20140116
            // what are these x and y?
            // int x = Cursor.Position.X;
            // int y = Cursor.Position.Y;
            
            var contextMenuSearcher =
                AutomationFactory.GetSearcherImpl<ContextMenuSearcher>();
            
            var contextMenuSearcherData =
                new ContextMenuSearcherData {
                InputObject = inputObject,
                ProcessId = inputObject.Current.ProcessId
            };
            
            var elementsMenuRoot =
                contextMenuSearcher.GetElements(
                    contextMenuSearcherData,
                    Preferences.Timeout);
            
            resultElement =
                elementsMenuRoot.Where(element => null != element).First();
            
            return resultElement;
        }
        
        public static bool GetIsValid(this IUiElement element)
        {
            if (null == element) return false;
            
            if (null == element.GetSourceElement()) return false;
            
            try {
                AutomationElement elementNet = element.GetSourceElement() as AutomationElement;
                if (null != elementNet) {
                    try {
                        var testVariable = elementNet.Current.Name;
                    } catch (Exception) {
                        return false;
                        // throw;
                    }
                    // if (null == elementNet.Cached) return false;
                    if (null == elementNet.Current.ProcessId || 0 == elementNet.Current.ProcessId) return false;
                }
            }
            catch {}
            
            return true;
        }
        
        public static string GetInfo(this IUiElement element)
        {
            string resultString = string.Empty;
            
            if (null == element) return resultString;
            
            try {
                if (null == element.Current) return resultString;
                
                if (!string.IsNullOrEmpty(element.Current.Name)) return element.Current.Name;
                if (!string.IsNullOrEmpty(element.Current.AutomationId)) return element.Current.AutomationId;
                if (!string.IsNullOrEmpty(element.Current.ClassName)) return element.Current.ClassName;
                
            } catch (Exception) {
                return resultString;
                // throw;
            }
            
            return resultString;
        }
        
        /// <summary>
        /// Checks that the -Value parameter matches the value ValuePattern of the element returns
        /// </summary>
        /// <param name="item">IUiElement element</param>
        /// <param name="textValue">the -Value parameter</param>
        /// <param name="viaWildcardOrRegex">true is wildcard, false is regexp</param>
        /// <param name="wildcardValue">a wildcard object</param>
        /// <param name="regexOptions">a regex options object</param>
        /// <returns></returns>
        internal static bool CompareElementValueAndValueParameter(
            this IUiElement element,
            string textValue,
            bool viaWildcardOrRegex,
            WildcardPattern wildcardValue,
            RegexOptions regexOptions)
        {
            bool result = false;
            
            // getting the real value of a control
            string realValue = string.Empty;
            try {
                realValue =
                    (element.GetCurrentPattern<IValuePattern>(ValuePattern.Pattern)).Current.Value;
            }
            catch { //(Exception eGetCurrentPattern) {
                // nothing to do
                // usually this place never be reached
            }
            
            result = viaWildcardOrRegex ? wildcardValue.IsMatch(realValue) : Regex.IsMatch(realValue, textValue, regexOptions);
            return result;
        }
    }
}
