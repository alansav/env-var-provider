using System;

namespace Savage.Providers
{
    public interface IEnvironmentVariableProvider
    {
        string GetEnvironmentVariable(string variable);
    }

    public class EnvironmentVariableProvider : IEnvironmentVariableProvider
    {
        public string GetEnvironmentVariable(string variable)
        {
            return Environment.GetEnvironmentVariable(variable);
        }
    }
}
