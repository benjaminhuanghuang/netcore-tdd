using System;
using Xunit;
//
using MyLibrary;

namespace MyLibrary.Tests
{
    public class FibonacciTests
    {
        [Fact]
        public void Fib_Given0_Return()
        {
            //arrange
            int n = 0;
            //act
            int res = Fibonacci.Fib(n);
            // assert
            Assert.Equal(0, res);
        }
        
        [Fact]
        public void Fib_Given1_Return1()
        {
            //arrange
            int n = 1;
            //act
            int res = Fibonacci.Fib(n);
            // assert
            Assert.Equal(1, res);
        }

        [Fact]
        public void Fib_Given2_Return1()
        {
            //arrange
            int n = 2;
            //act
            int res = Fibonacci.Fib(n);
            // assert
            Assert.Equal(1, res);
        }

        [Fact]
        public void Fib_Given3_Return2()
        {
            //arrange
            int n = 3;
            //act
            int res = Fibonacci.Fib(n);
            // assert
            Assert.Equal(2, res);
        }

    }
}
