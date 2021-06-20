using System;
using Xunit;

namespace Generics.Tests
{
    public class StackTests
    {
        [Fact]
        public void DoubleTypeStack()
        {
            var stack = new SimpleStack<double>();
            stack.Push(1.2);
            stack.Push(2.8);
            Assert.Equal(2, stack.Count);
            Assert.Equal(2.8, stack.Pop(),1);
            Assert.Equal(1.2, stack.Pop(),1);
        }

        [Fact]
        public void StringTypeStack()
        {
            var stack = new SimpleStack<string>();
            stack.Push("Test 01");
            stack.Push("Test 02");
            stack.Push("Test 03");
            Assert.Equal(3, stack.Count);
            Assert.Equal("Test 03", stack.Pop());
            Assert.Equal("Test 02", stack.Pop());
            Assert.Equal("Test 01", stack.Pop());
        }
    }
}
