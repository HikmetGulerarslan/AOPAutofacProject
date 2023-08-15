using AOPExample.Utilities.Interceptors;
using Castle.DynamicProxy;

namespace AOPExample.Aspects.Logging
{
    public class LogAspect : MethodInterception
    {
        protected override void OnSuccess(IInvocation invocation)
        {
            Console.WriteLine(invocation.Method.Name + " Log Kaydı Aldındı");
            Console.WriteLine("Geriye Dönüş Parametresi : " + invocation.ReturnValue );
        }
    }
}
