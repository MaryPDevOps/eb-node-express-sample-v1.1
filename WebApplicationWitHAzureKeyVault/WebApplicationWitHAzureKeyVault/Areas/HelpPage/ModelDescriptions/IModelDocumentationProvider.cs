using System;
using System.Reflection;

namespace WebApplicationWitHAzureKeyVault.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}