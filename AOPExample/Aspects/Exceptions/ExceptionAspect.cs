using AOPExample.Utilities.Interceptors;
using Castle.DynamicProxy;

namespace AOPExample.Aspects.Exceptions
{
    public class ExceptionAspect : MethodInterception
    {
        protected override void OnException(IInvocation invocation, Exception e)
        {
            Console.WriteLine("Exception in : " + invocation.Method.Name + " method." + e);
        }
    }
}
