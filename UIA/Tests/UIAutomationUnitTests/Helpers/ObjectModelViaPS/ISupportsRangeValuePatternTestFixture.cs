﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 1/8/2014
 * Time: 2:22 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace UIAutomationUnitTests.Helpers.ObjectModelViaPS
{
    using System;
    using System.Windows.Automation;
    using MbUnit.Framework;// using Xunit;
    using System.Management.Automation;
    using NSubstitute;
    using UIAutomation;
    
    /// <summary>
    /// Description of ISupportsRangeValuePatternTestFixture.
    /// </summary>
    [MbUnit.Framework.TestFixture][NUnit.Framework.TestFixture]
    public class ISupportsRangeValuePatternTestFixture
    {
        [MbUnit.Framework.SetUp][NUnit.Framework.SetUp]
        public void SetUp()
        {
            // MiddleLevelCode.PrepareRunspace();
        }
        
        [MbUnit.Framework.TearDown][NUnit.Framework.TearDown]
        public void TearDown()
        {
            // MiddleLevelCode.DisposeRunspace();
        }
        
//        [MbUnit.Framework.Test][NUnit.Framework.Test]
//        public void RangeValue_ImplementsCommonPattern()
//        {
//            ISupportsInvokePattern invokableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsInvokePattern;
//            
//            MbUnit.Framework.Assert.IsNotNull(invokableElement as ISupportsInvokePattern);
//            
//            ISupportsHighlighter highlightableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsHighlighter;
//            
//            MbUnit.Framework.Assert.IsNotNull(highlightableElement as ISupportsHighlighter);
//            
//            ISupportsNavigation navigatableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsNavigation;
//            
//            MbUnit.Framework.Assert.IsNotNull(navigatableElement as ISupportsNavigation);
//            
//            ISupportsConversion conversibleElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsConversion;
//            
//            MbUnit.Framework.Assert.IsNotNull(conversibleElement as ISupportsConversion);
//            
//            ISupportsRefresh refreshableElement =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsRefresh;
//            
//            MbUnit.Framework.Assert.IsNotNull(refreshableElement as ISupportsRefresh);
//        }
//        
//        [MbUnit.Framework.Test][NUnit.Framework.Test]
//        public void RangeValue_ImplementsPatternInQuestion()
//        {
//            ISupportsRangeValuePattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsRangeValuePattern;
//            
//            MbUnit.Framework.Assert.IsNotNull(element as ISupportsRangeValuePattern);
//        }
//        
//        [MbUnit.Framework.Test][NUnit.Framework.Test]
//        public void RangeValue_DoesNotImplementOtherPatterns()
//        {
//            ISupportsValuePattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsValuePattern;
//            
//            MbUnit.Framework.Assert.IsNull(element as ISupportsValuePattern);
//        }
//        
//        [MbUnit.Framework.Test][NUnit.Framework.Test]
//        public void RangeValue_IsRangeReadOnly()
//        {
//            // Arrange
//            bool expectedValue = true;
//            ISupportsRangeValuePattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData() { RangeValuePattern_IsReadOnly = expectedValue }) }) as ISupportsRangeValuePattern;
//            
//            // Act
//            
//            // Assert
//            MbUnit.Framework.Assert.AreEqual(expectedValue, element.IsRangeReadOnly);
//        }
//        
//        [MbUnit.Framework.Test][NUnit.Framework.Test]
//        public void RangeValue_LargeChange()
//        {
//            // Arrange
//            double expectedValue = 101.1;
//            ISupportsRangeValuePattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData() { RangeValuePattern_LargeChange = expectedValue }) }) as ISupportsRangeValuePattern;
//            
//            // Act
//            
//            // Assert
//            MbUnit.Framework.Assert.AreEqual(expectedValue, element.LargeChange);
//        }
//        
//        [MbUnit.Framework.Test][NUnit.Framework.Test]
//        public void RangeValue_Maximum()
//        {
//            // Arrange
//            double expectedValue = 1001.2;
//            ISupportsRangeValuePattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData() { RangeValuePattern_Maximum = expectedValue }) }) as ISupportsRangeValuePattern;
//            
//            // Act
//            
//            // Assert
//            MbUnit.Framework.Assert.AreEqual(expectedValue, element.Maximum);
//        }
//        
//        [MbUnit.Framework.Test][NUnit.Framework.Test]
//        public void RangeValue_Minimum()
//        {
//            // Arrange
//            double expectedValue = 15.3;
//            ISupportsRangeValuePattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData() { RangeValuePattern_Minimum = expectedValue }) }) as ISupportsRangeValuePattern;
//            
//            // Act
//            
//            // Assert
//            MbUnit.Framework.Assert.AreEqual(expectedValue, element.Minimum);
//        }
//        
//        [MbUnit.Framework.Test][NUnit.Framework.Test]
//        public void RangeValue_SmallChange()
//        {
//            // Arrange
//            double expectedValue = 5.4;
//            ISupportsRangeValuePattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData() { RangeValuePattern_SmallChange = expectedValue }) }) as ISupportsRangeValuePattern;
//            
//            // Act
//            
//            // Assert
//            MbUnit.Framework.Assert.AreEqual(expectedValue, element.SmallChange);
//        }
//        
//        [MbUnit.Framework.Test][NUnit.Framework.Test]
//        public void RangeValue_RangeValue_Get()
//        {
//            // Arrange
//            double expectedValue = 3.5;
//            ISupportsRangeValuePattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData() { RangeValuePattern_Value = expectedValue }) }) as ISupportsRangeValuePattern;
//            
//            // Act
//            
//            // Assert
//            MbUnit.Framework.Assert.AreEqual(expectedValue, element.RangeValue);
//        }
//        
//        [MbUnit.Framework.Test][NUnit.Framework.Test]
//        public void RangeValue_RangeValue_Set()
//        {
//            // Arrange
//            double expectedValue = 4.7;
//            ISupportsRangeValuePattern element =
//                FakeFactory.GetAutomationElementForMethodsOfObjectModel(
//                    new IBasePattern[] { FakeFactory.GetRangeValuePattern(new PatternsData()) }) as ISupportsRangeValuePattern;
//            
//            // Act
//            element.RangeValue = expectedValue;
//            try {
//                (element as IUiElement).GetCurrentPattern<IRangeValuePattern>(RangeValuePattern.Pattern).Received(1).SetValue(expectedValue);
//                element.RangeValue.Returns(expectedValue);
//                
//            }
//            catch {}
//            
//            // Assert
//            MbUnit.Framework.Assert.AreEqual(expectedValue, element.RangeValue);
//        }
    }
}
