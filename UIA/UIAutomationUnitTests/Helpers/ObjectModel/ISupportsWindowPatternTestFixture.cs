﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/22/2013
 * Time: 2:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomationUnitTests.Helpers.ObjectModel
{
    using System.Windows.Automation;
    using UIAutomation;
    using MbUnit.Framework;using Xunit;
    using NSubstitute;
    
    /// <summary>
    /// Description of ISupportsWindowPatternTestFixture.
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class ISupportsWindowPatternTestFixture
    {
        public ISupportsWindowPatternTestFixture()
        {
            FakeFactory.Init();
        }
        
        [SetUp]
        public void SetUp()
        {
            FakeFactory.Init();
        }
        
        [TearDown]
        public void TearDown()
        {
        }
        
        [Test][Fact]
        public void Window_ImplementsCommonPattern()
        {
//            ISupportsInvokePattern invokableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData()) }) as ISupportsInvokePattern;
//            
//            MbUnit.Framework.Assert.IsNotNull(invokableElement as ISupportsInvokePattern);
            
            ISupportsHighlighter highlightableElement =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData()) }) as ISupportsHighlighter;
            
            MbUnit.Framework.Assert.IsNotNull(highlightableElement as ISupportsHighlighter);
            Xunit.Assert.NotNull(highlightableElement as ISupportsHighlighter);
            
            ISupportsNavigation navigatableElement =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData()) }) as ISupportsNavigation;
            
            MbUnit.Framework.Assert.IsNotNull(navigatableElement as ISupportsNavigation);
            Xunit.Assert.NotNull(navigatableElement as ISupportsNavigation);
            
            ISupportsConversion conversibleElement =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData()) }) as ISupportsConversion;
            
            MbUnit.Framework.Assert.IsNotNull(conversibleElement as ISupportsConversion);
            Xunit.Assert.NotNull(conversibleElement as ISupportsConversion);
            
            ISupportsRefresh refreshableElement =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData()) }) as ISupportsRefresh;
            
            MbUnit.Framework.Assert.IsNotNull(refreshableElement as ISupportsRefresh);
            Xunit.Assert.NotNull(refreshableElement as ISupportsRefresh);
        }
        
        [Test][Fact]
        public void Window_ImplementsPatternInQuestion()
        {
            ISupportsWindowPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData()) }) as ISupportsWindowPattern;
            
            MbUnit.Framework.Assert.IsNotNull(element as ISupportsWindowPattern);
            Xunit.Assert.NotNull(element as ISupportsWindowPattern);
        }
        
        [Test][Fact]
        public void Window_DoesNotImplementOtherPatterns()
        {
            ISupportsValuePattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData()) }) as ISupportsValuePattern;
            
            MbUnit.Framework.Assert.IsNull(element as ISupportsValuePattern);
            Xunit.Assert.Null(element as ISupportsValuePattern);
        }
        
//        [Test][Fact]
//        public void Window_Close()
//        {
//            // Arrange
//            ISupportsWindowPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData()) }) as ISupportsWindowPattern;
//            
//            // Act
//            // Assert
//            element.Close();
//        }
        
//        [Test][Fact]
//        public void Window_SetWindowVisualState()
//        {
//            // Arrange
//            ISupportsWindowPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData()) }) as ISupportsWindowPattern;
//            
//            // Act
//            // Assert
//            element.SetWindowVisualState(WindowVisualState.Maximized);
//        }
//        
//        [Test][Fact]
//        public void Window_WaitForInputIdle()
//        {
//            // Arrange
//            ISupportsWindowPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData()) }) as ISupportsWindowPattern;
//            
//            // Act
//            // Assert
//            element.WaitForInputIdle(1);
//        }
        
        [Test][Fact]
        public void Window_CanMaximize()
        {
            // Arrange
            bool expectedValue = true;
            ISupportsWindowPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData() { WindowPattern_CanMaximize = expectedValue }) }) as ISupportsWindowPattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.CanMaximize);
            Xunit.Assert.Equal(expectedValue, element.CanMaximize);
        }
        
        [Test][Fact]
        public void Window_CanMinimize()
        {
            // Arrange
            bool expectedValue = false;
            ISupportsWindowPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData() { WindowPattern_CanMinimize = expectedValue }) }) as ISupportsWindowPattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.CanMinimize);
            Xunit.Assert.Equal(expectedValue, element.CanMinimize);
        }
        
        [Test][Fact]
        public void Window_IsModal()
        {
            // Arrange
            bool expectedValue = true;
            ISupportsWindowPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData() { WindowPattern_IsModal = expectedValue }) }) as ISupportsWindowPattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.IsModal);
            Xunit.Assert.Equal(expectedValue, element.IsModal);
        }
        
        [Test][Fact]
        public void Window_IsTopmost()
        {
            // Arrange
            bool expectedValue = false;
            ISupportsWindowPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData() { WindowPattern_IsTopmost = expectedValue }) }) as ISupportsWindowPattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.IsTopmost);
            Xunit.Assert.Equal(expectedValue, element.IsTopmost);
        }
        
        [Test][Fact]
        public void Window_WindowInteractionState()
        {
            // Arrange
            WindowInteractionState expectedValue = WindowInteractionState.ReadyForUserInteraction;
            ISupportsWindowPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData() { WindowPattern_WindowInteractionState = expectedValue }) }) as ISupportsWindowPattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.WindowInteractionState);
            Xunit.Assert.Equal(expectedValue, element.WindowInteractionState);
        }
        
        [Test][Fact]
        public void Window_WindowVisualState()
        {
            // Arrange
            WindowVisualState expectedValue = WindowVisualState.Normal;
            ISupportsWindowPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData() { WindowPattern_WindowVisualState = expectedValue }) }) as ISupportsWindowPattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.WindowVisualState);
            Xunit.Assert.Equal(expectedValue, element.WindowVisualState);
        }
        
        [Test][Fact]
        public void Window_Close()
        {
            // Arrange
            bool expectedResult = true;
            bool result = false;
            ISupportsWindowPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData()) }) as ISupportsWindowPattern;
            
            // Act
            element.Close();
            try {
                (element as IUiElement).GetCurrentPattern<IWindowPattern>(WindowPattern.Pattern).Received(1).Close();
                result = true;
            }
            catch {}
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedResult, result);
            Xunit.Assert.Equal(expectedResult, result);
        }
        
        [Test][Fact]
        public void Window_SetWindowVisualState()
        {
            // Arrange
            WindowVisualState expectedValue = WindowVisualState.Minimized;
            ISupportsWindowPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData()) }) as ISupportsWindowPattern;
            
            // Act
            element.SetWindowVisualState(expectedValue);
            try {
                (element as IUiElement).GetCurrentPattern<IWindowPattern>(WindowPattern.Pattern).Received(1).SetWindowVisualState(expectedValue);
                element.WindowVisualState.Returns(expectedValue);
                
            }
            catch {}
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.WindowVisualState);
            Xunit.Assert.Equal(expectedValue, element.WindowVisualState);
        }
        
        [Test][Fact]
        public void Window_WaitForInputIdle()
        {
            // Arrange
            bool expectedResult = true;
            bool result = false;
            ISupportsWindowPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetWindowPattern(new PatternsData()) }) as ISupportsWindowPattern;
            
            // Act
            element.WaitForInputIdle(1);
            try {
                (element as IUiElement).GetCurrentPattern<IWindowPattern>(WindowPattern.Pattern).Received(1).WaitForInputIdle(1);
                result = true;
            }
            catch {}
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedResult, result);
            Xunit.Assert.Equal(expectedResult, result);
        }
    }
}
