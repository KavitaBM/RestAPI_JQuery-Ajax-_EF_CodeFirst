using System;
using System.Reflection;

namespace RestAPI_JQuery_Ajax__EF_CodeFirst.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}