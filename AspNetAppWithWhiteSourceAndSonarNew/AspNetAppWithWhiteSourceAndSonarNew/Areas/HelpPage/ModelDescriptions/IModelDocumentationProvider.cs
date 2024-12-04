using System;
using System.Reflection;

namespace AspNetAppWithWhiteSourceAndSonarNew.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}