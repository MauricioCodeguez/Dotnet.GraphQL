using System.Reflection;

namespace Dotnet.GraphQL.CrossCutting.Extensions
{
    public static class LocalAssemblyExtensions
    {
        public static string GetEntryAssemblySuffix(this Assembly assembly)
            => Assembly.GetEntryAssembly()?.FullName?.Substring(0, 14);
    }
}