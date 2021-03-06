﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 2/19/2014
 * Time: 2:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomationUnitTests.Helpers.Inheritance
{
    // using System;
    // using System.Collections;
    using System.Collections.Generic;
    // using System.Collections.ObjectModel;
    using System.Windows.Automation;
    using UIAutomation;
    using MbUnit.Framework;using Xunit;
    // using System.Linq;
    using System.Management.Automation;
    
    /// <summary>
    /// Description of ControlFromWin32GatewayTestFixture.
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class ControlFromWin32GatewayTestFixture
    {
        public ControlFromWin32GatewayTestFixture()
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
        
        #region helpers
        private void TestParametersAgainstCollection(
            string containsText,
            string[] controlTypeNames,
            IEnumerable<IUiElement> collection,
            int expectedNumberOfElements)
        {
            // Arrange
//            IUiElement rootElement =
//                FakeFactory.GetElement_ForFindAll(
            
            // Act
            var resultList = RealCodeCaller.Win32Gateway_GetElements_NullInput(
                FakeFactory.GetAutomationElement(ControlType.Button, string.Empty, string.Empty, string.Empty, new IBasePattern[] {}, true),
                "aaaa");
            
            // Assert
            MbUnit.Framework.Assert.Count(expectedNumberOfElements, resultList);
            Xunit.Assert.Equal(expectedNumberOfElements, resultList.Count);
        }
        #endregion helpers
        
        #region Name
        [Test][Fact]
        public void Get0_byName()
        {
            const string containsText = "*ame??atche*";
            TestParametersAgainstCollection(
                containsText,
                null,
                new UiElement[] {},
                0);
        }
        
        [Test][Fact]
        public void Get0of3_byName()
        {
            const string containsText = "*ame??atche*";
            TestParametersAgainstCollection(
                containsText,
                null,
                new IUiElement[] {
                    FakeFactory.GetAutomationElementExpected(ControlType.Button, "other name", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementExpected(ControlType.Custom, "second name", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementExpected(ControlType.CheckBox, "third name", string.Empty, string.Empty, string.Empty)
                },
                3);
        }
        
        [Test][Fact]
        public void Get1of3_byName()
        {
            const string containsText = "*ame??atche*";
            TestParametersAgainstCollection(
                containsText,
                null,
                new IUiElement[] {
                    FakeFactory.GetAutomationElementExpected(ControlType.Tab, "other name", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementExpected(ControlType.Image, "name matches", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementExpected(ControlType.Button, "third name", string.Empty, string.Empty, string.Empty)
                },
                3);
        }
        
        [Test][Fact]
        public void Get3of3_byName()
        {
            const string containsText = "*ame??atche*";
            TestParametersAgainstCollection(
                containsText,
                null,
                new IUiElement[] {
                    FakeFactory.GetAutomationElementExpected(ControlType.Button, "name matches", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementExpected(ControlType.Custom, "Name matches", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementExpected(ControlType.Hyperlink, "name matcheZ", string.Empty, string.Empty, string.Empty)
                },
                3);
        }
        #endregion Name
        
        #region ControlType + Name
        [Test][Fact]
        public void Get0_byControlTypeName()
        {
            const string containsText = "*ame??atche*";
            ControlType controlType = ControlType.Button;
            TestParametersAgainstCollection(
                containsText,
                controlType.ConvertControlTypeToStringArray(),
                new UiElement[] {},
                0);
        }
        
        [Test][Fact]
        public void Get0of4_byControlTypeName()
        {
            const string containsText = "*ame??atche*";
            ControlType controlType = ControlType.Button;
            TestParametersAgainstCollection(
                containsText,
                controlType.ConvertControlTypeToStringArray(),
                new IUiElement[] {
                    FakeFactory.GetAutomationElementExpected(controlType, "other name", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementExpected(controlType, "second name", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementExpected(controlType, "third name", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementNotExpected(ControlType.DataGrid, containsText, string.Empty, string.Empty, string.Empty)
                },
                3);
        }
        
        [Test][Fact]
        public void Get1of4_byControlTypeName()
        {
            const string containsText = "*ame??atche*";
            ControlType controlType = ControlType.Button;
            TestParametersAgainstCollection(
                containsText,
                controlType.ConvertControlTypeToStringArray(),
                new IUiElement[] {
                    FakeFactory.GetAutomationElementExpected(controlType, "other name", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementExpected(controlType, "name matches", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementExpected(controlType, "third name", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementNotExpected(ControlType.Group, containsText, string.Empty, string.Empty, string.Empty)
                },
                3);
        }
        
        [Test][Fact]
        public void Get3of3_byControlTypeName()
        {
            const string containsText = "*ame??atche*";
            ControlType controlType = ControlType.Button;
            TestParametersAgainstCollection(
                containsText,
                controlType.ConvertControlTypeToStringArray(),
                new IUiElement[] {
                    FakeFactory.GetAutomationElementExpected(controlType, "name matches", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementExpected(controlType, "NNName matches", string.Empty, string.Empty, string.Empty),
                    FakeFactory.GetAutomationElementExpected(controlType, "name matcheZ", string.Empty, string.Empty, string.Empty)
                },
                3);
        }
        #endregion ControlType + Name
    }
}
