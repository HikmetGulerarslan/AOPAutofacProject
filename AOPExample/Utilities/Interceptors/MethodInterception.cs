using Castle.DynamicProxy;

namespace AOPExample.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        /// <summary>
        /// Metod çalışmadan önce
        /// </summary>
        /// <param name="ınvocation"></param>
        protected virtual void OnBefore(IInvocation invocation)
        { }

        /// <summary>
        /// Metod çalıştıktan sonra
        /// </summary>
        /// <param name="ınvocation"></param>
        protected virtual void OnAfter(IInvocation invocation)
        {

        }

        /// <summary>
        ///  Hata (Exception) alındığında
        /// </summary>
        /// <param name="ınvocation"></param>
        protected virtual void OnException(IInvocation invocation, Exception e)
        {

        }

        /// <summary>
        /// İşlem başarılı olduğunda
        /// </summary>
        /// <param name="ınvocation"></param>
        protected virtual void OnSuccess(IInvocation invocation)
        {

        }

        public override void Intercept(IInvocation invocation)
        {
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
                if (invocation.ReturnValue is Task returnValueTask)
                {
                    returnValueTask.GetAwaiter().GetResult();
                }

                if (invocation.ReturnValue is Task task && task.Exception != null)
                {
                    throw task.Exception;
                }
                OnSuccess(invocation);
                OnAfter(invocation);
            }
            catch (Exception e)
            {
                OnException(invocation, e);
            }
            OnAfter(invocation);
        }
    }
}
