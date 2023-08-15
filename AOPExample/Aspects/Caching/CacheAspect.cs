using AOPExample.CrossCuttingConcers.Caching;
using AOPExample.Utilities.Interceptors;
using Castle.DynamicProxy;

namespace AOPExample.Aspects.Caching
{
    public class CacheAspect : MethodInterception
    {
        private readonly int _duration;
        private readonly ICacheService _cacheService;

        public CacheAspect(int duration)
        {
            _duration = duration;
            _cacheService = (ICacheService)Utilities.Helpers.HttpContext.Current.RequestServices.GetService(typeof(ICacheService));
        }

        public override void Intercept(IInvocation invocation)
        {

            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");
            var arguments = invocation.Arguments.ToList();
            var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})";
            if (_cacheService.IsAdd(key))
            {
                var daa = _cacheService.Get(key);
                invocation.ReturnValue = daa;
                return;
            }
            invocation.Proceed();
            _cacheService.Add(key, invocation.ReturnValue, _duration);
        }
    }
}
