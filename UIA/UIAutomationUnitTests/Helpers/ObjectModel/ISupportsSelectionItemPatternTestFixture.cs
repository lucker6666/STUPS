﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 12/22/2013
 * Time: 2:51 AM
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
    /// Description of ISupportsSelectionItemPatternTestFixture.
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class ISupportsSelectionItemPatternTestFixture
    {
        public ISupportsSelectionItemPatternTestFixture()
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
        public void SelectionItem_ImplementsCommonPattern()
        {
//            ISupportsInvokePattern invokableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetSelectionItemPattern(new PatternsData()) }) as ISupportsInvokePattern;
//            
//            MbUnit.Framework.Assert.IsNotNull(invokableElement as ISupportsInvokePattern);
            
            ISupportsHighlighter highlightableElement =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetSelectionItemPattern(new PatternsData()) }) as ISupportsHighlighter;
            
            MbUnit.Framework.Assert.IsNotNull(highlightableElement as ISupportsHighlighter);
            Xunit.Assert.NotNull(highlightableElement as ISupportsHighlighter);
            
            ISupportsNavigation navigatableElement =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetSelectionItemPattern(new PatternsData()) }) as ISupportsNavigation;
            
            MbUnit.Framework.Assert.IsNotNull(navigatableElement as ISupportsNavigation);
            Xunit.Assert.NotNull(navigatableElement as ISupportsNavigation);
            
            ISupportsConversion conversibleElement =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetSelectionItemPattern(new PatternsData()) }) as ISupportsConversion;
            
            MbUnit.Framework.Assert.IsNotNull(conversibleElement as ISupportsConversion);
            Xunit.Assert.NotNull(conversibleElement as ISupportsConversion);
            
            ISupportsRefresh refreshableElement =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetSelectionItemPattern(new PatternsData()) }) as ISupportsRefresh;
            
            MbUnit.Framework.Assert.IsNotNull(refreshableElement as ISupportsRefresh);
            Xunit.Assert.NotNull(refreshableElement as ISupportsRefresh);
        }
        
        [Test][Fact]
        public void SelectionItem_ImplementsPatternInQuestion()
        {
            ISupportsSelectionItemPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetSelectionItemPattern(new PatternsData()) }) as ISupportsSelectionItemPattern;
            
            MbUnit.Framework.Assert.IsNotNull(element as ISupportsSelectionItemPattern);
            Xunit.Assert.NotNull(element as ISupportsSelectionItemPattern);
        }
        
        [Test][Fact]
        public void SelectionItem_DoesNotImplementOtherPatterns()
        {
            ISupportsValuePattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetSelectionItemPattern(new PatternsData()) }) as ISupportsValuePattern;
            
            MbUnit.Framework.Assert.IsNull(element as ISupportsValuePattern);
            Xunit.Assert.Null(element as ISupportsValuePattern);
        }
        
        [Test][Fact]
        public void SelectionItem_AddToSelection()
        {
            // Arrange
            bool expectedResult = true;
            bool result = false;
            ISupportsSelectionItemPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetSelectionItemPattern(new PatternsData()) }) as ISupportsSelectionItemPattern;
            
            // Act
            element.AddToSelection();
            try {
                (element as IUiElement).GetCurrentPattern<ISelectionItemPattern>(SelectionItemPattern.Pattern).Received(1).AddToSelection();
                result = true;
            }
            catch {}
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedResult, result);
            Xunit.Assert.Equal(expectedResult, result);
        }
        
        [Test][Fact]
        public void SelectionItem_RemoveFromSelection()
        {
            // Arrange
            bool expectedResult = true;
            bool result = false;
            ISupportsSelectionItemPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetSelectionItemPattern(new PatternsData()) }) as ISupportsSelectionItemPattern;
            
            // Act
            element.RemoveFromSelection();
            try {
                (element as IUiElement).GetCurrentPattern<ISelectionItemPattern>(SelectionItemPattern.Pattern).Received(1).RemoveFromSelection();
                result = true;
            }
            catch {}
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedResult, result);
            Xunit.Assert.Equal(expectedResult, result);
        }
        
        [Test][Fact]
        public void SelectionItem_Select()
        {
            // Arrange
            bool expectedResult = true;
            bool result = false;
            ISupportsSelectionItemPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetSelectionItemPattern(new PatternsData()) }) as ISupportsSelectionItemPattern;
            
            // Act
            element.Select();
            try {
                (element as IUiElement).GetCurrentPattern<ISelectionItemPattern>(SelectionItemPattern.Pattern).Received(1).Select();
                result = true;
            }
            catch {}
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedResult, result);
            Xunit.Assert.Equal(expectedResult, result);
        }
        
        [Test][Fact]
        public void SelectionItem_IsSelected()
        {
            // Arrange
            bool expectedValue = true;
            ISupportsSelectionItemPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetSelectionItemPattern(new PatternsData() { SelectionItemPattern_IsSelected = expectedValue }) }) as ISupportsSelectionItemPattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.IsSelected);
            Xunit.Assert.Equal(expectedValue, element.IsSelected);
        }
        
        [Test][Fact]
        public void SelectionItem_SelectionContainer()
        {
            // Arrange
            IUiElement expectedValue = new UiElement();
            ISupportsSelectionItemPattern element =
                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
                    new IBasePattern[] { FakeFactory.GetSelectionItemPattern(new PatternsData() { SelectionItemPattern_SelectionContainer = expectedValue }) }) as ISupportsSelectionItemPattern;
            
            // Act
            
            // Assert
            MbUnit.Framework.Assert.AreEqual(expectedValue, element.SelectionContainer);
            Xunit.Assert.Equal(expectedValue, element.SelectionContainer);
        }
    }
}
