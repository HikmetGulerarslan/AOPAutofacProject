using AOPExample.CrossCuttingConcers.Caching;
using AOPExample.Utilities.Interceptors;
using Castle.DynamicProxy;

namespace AOPExample.Aspects.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _methodName;
        private readonly ICacheService _cacheService;

        public CacheRemoveAspect(string methodName)
        {
            _methodName = methodName;
            _cacheService = (ICacheService)Utilities.Helpers.HttpContext.Current.RequestServices.GetService(typeof(ICacheService));
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            //Todo: 10.01.2022  CacheRemoveAspect  Remove'da düzenleme yapılacak.
            _cacheService.Remove($"{_methodName}()");
        }
    }
}
