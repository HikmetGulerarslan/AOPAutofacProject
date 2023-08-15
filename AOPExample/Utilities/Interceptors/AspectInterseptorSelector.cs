using Castle.DynamicProxy;
using System.Reflection;

namespace AOPExample.Utilities.Interceptors
{
    public class AspectInterseptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>().ToList();
            var methodAttributes = type.GetMethod(method.Name).GetCustomAttributes<MethodInterceptionBaseAttribute>();
            classAttributes.AddRange(methodAttributes);
            return classAttributes.ToArray();
        }
    }
}
