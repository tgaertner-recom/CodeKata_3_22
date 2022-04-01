using System;
using Calculator;
using FluentAssertions;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    public class FieldAxiomTests
    {
        [TestCase(1,0,1)]
        [TestCase(1,1,2)]
        [TestCase(1,-1,0)]
        [TestCase(-1,0,-1)]
        [TestCase(-1,1,0)]
        [TestCase(-1,-1,-2)]
        [TestCase(0,0,0)]
        [TestCase(0,1,1)]
        [TestCase(0,-1,-1)]
        public void Test_Add(double op1, double op2, double expected)
        {
            var result = SimpleCalculator.Add(op1, op2);
            result.Should().Be(expected);
        }

        [Test]
        public void Add_should_respect_neutral_element_off_addition()
        {
            var result = SimpleCalculator.Add(1, 0);
            result.Should().Be(1);
        }
        
        [TestCase(1,0,1)]
        [TestCase(1,1,0)]
        [TestCase(1,-1,2)]
        [TestCase(-1,0,-1)]
        [TestCase(-1,1,-2)]
        [TestCase(-1,-1,0)]
        [TestCase(0,0,0)]
        [TestCase(0,1,-1)]
        [TestCase(0,-1,1)]
        public void Test_Diff(double op1, double op2, double expected)
        {
            var result = SimpleCalculator.Diff(op1, op2);
            result.Should().Be(expected);
        }

        [Test]
        public void Diff_should_respect_inverse_element_off_addition()
        {
            var result = SimpleCalculator.Diff(1, 1);
            result.Should().Be(0);
        }
        
        [TestCase(2,0,0)]
        [TestCase(2,1,2)]
        [TestCase(2,-1,-2)]        
        [TestCase(1,0,0)]
        [TestCase(1,1,1)]
        [TestCase(1,-1,-1)]
        [TestCase(-1,0,0)]
        [TestCase(-1,1,-1)]
        [TestCase(-1,-1,1)]
        [TestCase(0,0,0)]
        [TestCase(0,1,0)]
        [TestCase(0,-1,0)]
        public void Test_Mult(double op1, double op2, double expected)
        {
            var result = SimpleCalculator.Mult(op1, op2);
            result.Should().Be(expected);
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