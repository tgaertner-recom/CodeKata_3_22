using System;
using Calculator;
using FluentAssertions;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    public class FieldAxiomTests
    {
        [Test]
        public void Add_should_respect_neutral_element_off_addition()
        {
            var result = SimpleCalculator.Add(1, 0);
            result.Should().Be(1);
        }
        
        [Test]
        public void Diff_should_respect_inverse_element_off_addition()
        {
            var result = SimpleCalculator.Diff(1, 1);
            result.Should().Be(0);
        }
        
        [Test]
        public void Mult_should_respect_neutral_element_off_multiplication()
        {
            var result = SimpleCalculator.Mult(5, 1);
            result.Should().Be(5);
        }
        
        [Test]
        public void Div_should_respect_inverse_element_off_multiplication()
        {
            var result = SimpleCalculator.Div(5, 5);
            result.Should().Be(1);
        }
        
        [Test]
        public void Div_by_zero_should_throw_exception()
        {
            Action action = () => SimpleCalculator.Div(5, 0);
            action.Should().Throw<Exception>();
        }
    }
}