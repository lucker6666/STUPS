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
    /// Description of ISupportsRangeValuePatternTestFixture.
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class ISupportsRangeValuePatternTestFixture
    {
        public ISupportsRangeValuePatternTestFixture()
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
        public void RangeValue_ImplementsCommonPattern()
        {
//            ISupportsInvokePattern invokableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsInvokePattern;
//            
//            MbUnit.Framework.Assert.IsNotNull(invokableElement as ISupportsInvokePattern);
            
            ISupportsHighlighter highlightableElement =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsHighlighter;
            
            MbUnit.Framework.Assert.IsNotNull(highlightableElement as ISupportsHighlighter);
            Xunit.Assert.NotNull(highlightableElement as ISupportsHighlighter);
            
            ISupportsNavigation navigatableElement =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsNavigation;
            
            MbUnit.Framework.Assert.IsNotNull(navigatableElement as ISupportsNavigation);
            Xunit.Assert.NotNull(navigatableElement as ISupportsNavigation);
            
            ISupportsConversion conversibleElement =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsConversion;
            
            MbUnit.Framework.Assert.IsNotNull(conversibleElement as ISupportsConversion);
            Xunit.Assert.NotNull(conversibleElement as ISupportsConversion);
            
            ISupportsRefresh refreshableElement =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsRefresh;
            
            MbUnit.Framework.Assert.IsNotNull(refreshableElement as ISupportsRefresh);
            Xunit.Assert.NotNull(refreshableElement as ISupportsRefresh);
        }
        
        [Test][Fact]
        public void RangeValue_ImplementsPatternInQuestion()
        {
            ISupportsRangeValuePattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsRangeValuePattern;
            
            MbUnit.Framework.Assert.IsNotNull(element as ISupportsRangeValuePattern);
            Xunit.Assert.NotNull(element as ISupportsRangeValuePattern);
        }
        
        [Test][Fact]
        public void RangeValue_DoesNotImplementOtherPatterns()
        {
            ISupportsValuePattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsValuePattern;
            
            MbUnit.Framework.Assert.IsNull(element as ISupportsValuePattern);
            Xunit.Assert.Null(element as ISupportsValuePattern);
        }
        
        [Test][Fact]
        public void RangeValue_IsRangeReadOnly()
        {
            // Arrange
            bool expectedValue = true;
            ISupportsRangeValuePattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData() { RangeValuePattern_IsReadOnly = expectedValue }) }) as ISupportsRangeValuePattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.IsRangeReadOnly);
            Xunit.Assert.Equal(expectedValue, element.IsRangeReadOnly);
        }
        
        [Test][Fact]
        public void RangeValue_LargeChange()
        {
            // Arrange
            double expectedValue = 101.1;
            ISupportsRangeValuePattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData() { RangeValuePattern_LargeChange = expectedValue }) }) as ISupportsRangeValuePattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.LargeChange);
            Xunit.Assert.Equal(expectedValue, element.LargeChange);
        }
        
        [Test][Fact]
        public void RangeValue_Maximum()
        {
            // Arrange
            double expectedValue = 1001.2;
            ISupportsRangeValuePattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData() { RangeValuePattern_Maximum = expectedValue }) }) as ISupportsRangeValuePattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.Maximum);
            Xunit.Assert.Equal(expectedValue, element.Maximum);
        }
        
        [Test][Fact]
        public void RangeValue_Minimum()
        {
            // Arrange
            double expectedValue = 15.3;
            ISupportsRangeValuePattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData() { RangeValuePattern_Minimum = expectedValue }) }) as ISupportsRangeValuePattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.Minimum);
            Xunit.Assert.Equal(expectedValue, element.Minimum);
        }
        
        [Test][Fact]
        public void RangeValue_SmallChange()
        {
            // Arrange
            double expectedValue = 5.4;
            ISupportsRangeValuePattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData() { RangeValuePattern_SmallChange = expectedValue }) }) as ISupportsRangeValuePattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.SmallChange);
            Xunit.Assert.Equal(expectedValue, element.SmallChange);
        }
        
        [Test][Fact]
        public void RangeValue_RangeValue_Get()
        {
            // Arrange
            double expectedValue = 3.5;
            ISupportsRangeValuePattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData() { RangeValuePattern_Value = expectedValue }) }) as ISupportsRangeValuePattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.RangeValue);
            Xunit.Assert.Equal(expectedValue, element.RangeValue);
        }
        
        [Test][Fact]
        public void RangeValue_RangeValue_Set()
        {
            // Arrange
            double expectedValue = 4.7;
            ISupportsRangeValuePattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsRangeValuePattern;
            
            // Act
            element.RangeValue = expectedValue;
            try {
                (element as IUiElement).GetCurrentPattern<IRangeValuePattern>(RangeValuePattern.Pattern).Received(1).SetValue(expectedValue);
                element.RangeValue.Returns(expectedValue);
                
            }
            catch {}
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.RangeValue);
            Xunit.Assert.Equal(expectedValue, element.RangeValue);
        }
    }
}
