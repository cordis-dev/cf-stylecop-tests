using System;
using System.Diagnostics;

namespace Tests.csharp7
{
	public class IsExpression
	{		
		public void T()
		{		 
			if (content is byte[] bytes)
			{
				SetRequestContent(request, bytes);
			}
			
			try
            {
                a = b.GetValue(c);
            }
            catch (Exception e)
            {		
			    if (e is System.TimeoutException)
				{
					throw;
				}
				
                if (e is AccessViolationException || e is StackOverflowException)
                {
                    throw;
                }				
            }
			
			Debug.Assert(a is Run, "test");
			
			ParameterProcessor processor = cmdlet is SortObjectCommand ?
                new ParameterProcessor(new SortObjectExpressionParameterDefinition()) :
                new ParameterProcessor(new GroupObjectExpressionParameterDefinition());
		}
	}
}