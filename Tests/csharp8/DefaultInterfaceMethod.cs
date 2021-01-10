using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Emit;

namespace System.Management.Automation.Language
{
    public interface ICustomAstVisitor
    {
        object DefaultVisit(Ast ast) => null;
		object Classic(object ast);
	}
}
