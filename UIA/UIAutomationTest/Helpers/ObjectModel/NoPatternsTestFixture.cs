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
    /// Description of NoPatternsTestFixture.
    /// </summary>
    [TestFixture]
    public class NoPatternsTestFixture
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
//        public void NoPatterns_ImplementsCommonPattern()
//        {
//            ISupportsInvokePattern invokableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] {}) as ISupportsInvokePattern;
//            
//            Assert.IsNotNull(invokableElement as ISupportsInvokePattern);
//            
//            ISupportsHighlighter highlightableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] {}) as ISupportsHighlighter;
//            
//            Assert.IsNotNull(highlightableElement as ISupportsHighlighter);
//            
//            ISupportsNavigation navigatableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] {}) as ISupportsNavigation;
//            
//            Assert.IsNotNull(navigatableElement as ISupportsNavigation);
//            
//            ISupportsConversion conversibleElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] {}) as ISupportsConversion;
//            
//            Assert.IsNotNull(conversibleElement as ISupportsConversion);
//            
//            ISupportsRefresh refreshableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] {}) as ISupportsRefresh;
//            
//            Assert.IsNotNull(refreshableElement as ISupportsRefresh);
//        }
    }
}
