using FluentAssertions;
using Xunit;

namespace FizzBuzzKataNetCore
{
    public class DummyTests
    {
        [Fact]
        public void When_Then()
        {
            var sut = new Dummy();

            string result = sut.SayHelloWorld();

            result.Should().Be("Hello world!");
        }
    }
}
