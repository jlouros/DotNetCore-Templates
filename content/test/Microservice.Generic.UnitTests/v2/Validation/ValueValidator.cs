using System;
using System.Collections.Generic;
using System.Text;
using Microservice.Generic.v2.Validation.Impl;
using NUnit.Framework;

namespace Microservice.Generic.Tests.v2.Validation
{
    public class ValueValidatorTests
    {
		ValueValidator _valueValidator { get; set; }

		[SetUp]
        public void Setup()
        {
			_valueValidator = new ValueValidator();
		}

        [Test]
        public void IsGreaterThanZero_Returns_True_For_Positive_Values()
        {
            // act
            var result = _valueValidator.IsPositive(2);

            // assert
            Assert.AreEqual(true, result);
        }
    }
}
