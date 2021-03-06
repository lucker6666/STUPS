﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 2/13/2014
 * Time: 11:54 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomationUnitTests.Commands.Wait
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Automation;
    using UIAutomation;
    using MbUnit.Framework;using Xunit;
    using System.Linq;
    using UIAutomation.Commands;
    using UIAutomation.Helpers.Commands;
    
    /// <summary>
    /// Description of WaitUIAControlIsVisibleCommandTestFixture.
    /// </summary>
    [MbUnit.Framework.TestFixture]
    public class WaitUIAControlIsVisibleCommandTestFixture
    {
        public WaitUIAControlIsVisibleCommandTestFixture()
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
//        private void TestParametersAgainstCollection(
//            Hashtable[] inputData,
//            IEnumerable<IUiElement> collection,
//            bool expectedResult)
//        {
//            // Arrange
//            var data =
//                new ControlSearcherData {
//                SearchCriteria = inputData
//            };
//            
//            Condition condition =
//                ControlSearcher.GetWildcardSearchCondition(data);
//            
//            IUiElement element =
//                FakeFactory.GetElement_ForFindAll(
//                    collection,
//                    condition);
//            
//            var cmdlet =
//                new WaitUiaControlStateCommand {
//                SearchCriteria = inputData,
//                InputObject = new[] { element }
//            };
//            
//            // Act
//            var command = new WaitControlStateCommand(cmdlet);
//            command.Execute();
//            
//            // Assert
//            MbUnit.Framework.Assert.AreEqual<bool>(
//                expectedResult,
//                (bool)PSTestLib.UnitTestOutput.LastOutput[0]);
//            Xunit.Assert.Equal<bool>(
//                expectedResult,
//                (bool)PSTestLib.UnitTestOutput.LastOutput[0]);
//        }
        #endregion helpers
    }
}
