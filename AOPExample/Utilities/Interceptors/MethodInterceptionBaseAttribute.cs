using Castle.DynamicProxy;

namespace AOPExample.Utilities.Interceptors
{
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public virtual void Intercept(IInvocation invocation)
        {
        }
    }
}
