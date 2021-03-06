﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/7/2014
 * Time: 5:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomationTest.Helpers.ObjectModel
{
    using System;
    using MbUnit.Framework;
    using System.Management.Automation;
    
    /// <summary>
    /// Description of ISupportsScrollPatternTestFixture.
    /// </summary>
    [TestFixture]
    public class ISupportsScrollPatternTestFixture
    {
        [SetUp]
        public void SetUp()
        {
            MiddleLevelCode.PrepareRunspace();
        }
        
        [TearDown]
        public void TearDown()
        {
            MiddleLevelCode.DisposeRunspace();
        }
        
//        [Test]
//        public void Scroll_ImplementsCommonPattern()
//        {
//            ISupportsInvokePattern invokableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData()) }) as ISupportsInvokePattern;
//            
//            Assert.IsNotNull(invokableElement as ISupportsInvokePattern);
//            
//            
//            ISupportsHighlighter highlightableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData()) }) as ISupportsHighlighter;
//            
//            Assert.IsNotNull(highlightableElement as ISupportsHighlighter);
//            
//            ISupportsNavigation navigatableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData()) }) as ISupportsNavigation;
//            
//            Assert.IsNotNull(navigatableElement as ISupportsNavigation);
//            
//            ISupportsConversion conversibleElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData()) }) as ISupportsConversion;
//            
//            Assert.IsNotNull(conversibleElement as ISupportsConversion);
//            
//            ISupportsRefresh refreshableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData()) }) as ISupportsRefresh;
//            
//            Assert.IsNotNull(refreshableElement as ISupportsRefresh);
//        }
//        
//        [Test]
//        public void Scroll_ImplementsPatternInQuestion()
//        {
//            ISupportsScrollPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData()) }) as ISupportsScrollPattern;
//            
//            Assert.IsNotNull(element as ISupportsScrollPattern);
//        }
//        
//        [Test]
//        public void Scroll_DoesNotImplementOtherPatterns()
//        {
//            ISupportsValuePattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData()) }) as ISupportsValuePattern;
//            
//            Assert.IsNull(element as ISupportsValuePattern);
//        }
//        
//        [Test]
//        public void Scroll_Scroll()
//        {
//            // Arrange
//            bool expectedResult = true;
//            bool result = false;
//            ISupportsScrollPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData()) }) as ISupportsScrollPattern;
//            
//            // Act
//            element.Scroll(ScrollAmount.LargeIncrement, ScrollAmount.LargeIncrement);
//            try {
//                (element as IUiElement).GetCurrentPattern<IScrollPattern>(ScrollPattern.Pattern).Received(1).Scroll(ScrollAmount.LargeIncrement, ScrollAmount.LargeIncrement);
//                result = true;
//            }
//            catch {}
//            
//            // Assert
//            Assert.AreEqual(expectedResult, result);
//        }
//        
//        [Test]
//        public void Scroll_ScrollHorizontal()
//        {
//            // Arrange
//            bool expectedResult = true;
//            bool result = false;
//            ISupportsScrollPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData()) }) as ISupportsScrollPattern;
//            
//            // Act
//            element.ScrollHorizontal(ScrollAmount.LargeIncrement);
//            try {
//                (element as IUiElement).GetCurrentPattern<IScrollPattern>(ScrollPattern.Pattern).Received(1).ScrollHorizontal(ScrollAmount.LargeIncrement);
//                result = true;
//            }
//            catch {}
//            
//            // Assert
//            Assert.AreEqual(expectedResult, result);
//        }
//        
//        [Test]
//        public void Scroll_ScrollVertical()
//        {
//            // Arrange
//            bool expectedResult = true;
//            bool result = false;
//            ISupportsScrollPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData()) }) as ISupportsScrollPattern;
//            
//            // Act
//            element.ScrollVertical(ScrollAmount.LargeIncrement);
//            try {
//                (element as IUiElement).GetCurrentPattern<IScrollPattern>(ScrollPattern.Pattern).Received(1).ScrollVertical(ScrollAmount.LargeIncrement);
//                result = true;
//            }
//            catch {}
//            
//            // Assert
//            Assert.AreEqual(expectedResult, result);
//        }
//        
//        [Test]
//        public void Scroll_SetScrollPercent()
//        {
//            // Arrange
//            bool expectedResult = true;
//            bool result = false;
//            ISupportsScrollPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData()) }) as ISupportsScrollPattern;
//            
//            // Act
//            element.SetScrollPercent(1, 1);
//            try {
//                (element as IUiElement).GetCurrentPattern<IScrollPattern>(ScrollPattern.Pattern).Received(1).SetScrollPercent(1, 1);
//                result = true;
//            }
//            catch {}
//            
//            // Assert
//            Assert.AreEqual(expectedResult, result);
//        }
//        
//                
//        [Test]
//        public void Scroll_HorizontallyScrollable()
//        {
//            // Arrange
//            bool expectedValue = true;
//            ISupportsScrollPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData() { ScrollPattern_HorizontallyScrollable = expectedValue }) }) as ISupportsScrollPattern;
//            
//            // Act
//            
//            // Assert
//            Assert.AreEqual(expectedValue, element.HorizontallyScrollable);
//        }
//        
//        [Test]
//        public void Scroll_HorizontalScrollPercent()
//        {
//            // Arrange
//            double expectedValue = 12.1;
//            ISupportsScrollPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData() { ScrollPattern_HorizontalScrollPercent = expectedValue }) }) as ISupportsScrollPattern;
//            
//            // Act
//            
//            // Assert
//            Assert.AreEqual(expectedValue, element.HorizontalScrollPercent);
//        }
//        
//        [Test]
//        public void Scroll_HorizontalViewSize()
//        {
//            // Arrange
//            double expectedValue = 14.2;
//            ISupportsScrollPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData() { ScrollPattern_HorizontalViewSize = expectedValue }) }) as ISupportsScrollPattern;
//            
//            // Act
//            
//            // Assert
//            Assert.AreEqual(expectedValue, element.HorizontalViewSize);
//        }
//        
//        [Test]
//        public void Scroll_VerticallyScrollable()
//        {
//            // Arrange
//            bool expectedValue = false;
//            ISupportsScrollPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData() { ScrollPattern_VerticallyScrollable = expectedValue }) }) as ISupportsScrollPattern;
//            
//            // Act
//            
//            // Assert
//            Assert.AreEqual(expectedValue, element.VerticallyScrollable);
//        }
//        
//        [Test]
//        public void Scroll_VerticalScrollPercent()
//        {
//            // Arrange
//            double expectedValue = 16.3;
//            ISupportsScrollPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData() { ScrollPattern_VerticalScrollPercent = expectedValue }) }) as ISupportsScrollPattern;
//            
//            // Act
//            
//            // Assert
//            Assert.AreEqual(expectedValue, element.VerticalScrollPercent);
//        }
//        
//        [Test]
//        public void Scroll_VerticalViewSize()
//        {
//            // Arrange
//            double expectedValue = 18.4;
//            ISupportsScrollPattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetScrollPattern(new PatternsData() { ScrollPattern_VerticalViewSize = expectedValue }) }) as ISupportsScrollPattern;
//            
//            // Act
//            
//            // Assert
//            Assert.AreEqual(expectedValue, element.VerticalViewSize);
//        }
    }
}
