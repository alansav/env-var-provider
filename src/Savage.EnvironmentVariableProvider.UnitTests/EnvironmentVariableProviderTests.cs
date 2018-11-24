using System;
using Xunit;

namespace Savage.Providers
{
    public class EnvironmentVariableProviderTests
    {
        [Fact]
        public void GetEnvironmentVariable_returns_Value()
        {
            string environmentVariableToGet = null;
            foreach (var key in Environment.GetEnvironmentVariables().Keys)
            {
                environmentVariableToGet = key.ToString();
                break;
            }

            var expectedValue = Environment.GetEnvironmentVariable(environmentVariableToGet);

            var sut = new EnvironmentVariableProvider();
            var actualValue = sut.GetEnvironmentVariable(environmentVariableToGet);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void GetEnvironmentVariable_returns_null_when_environment_variable_not_found()
        {
            var sut = new EnvironmentVariableProvider();
            var actualValue = sut.GetEnvironmentVariable("DOES_NOT_EXIST");
            Assert.Null(actualValue);
        }
    }
}
