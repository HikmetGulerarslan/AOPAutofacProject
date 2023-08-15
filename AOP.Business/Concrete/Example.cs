using AOP.Business.Abstract;
using AOPExample.Aspects.Logging;
using AOPExample.Aspects.Performance;

namespace AOP.Business.Concrete
{
    public class Example : IExample
    {
        [LogAspect, PerformanceAspect(5)]
        public string ExampleMethod()
        {
            return "Example Method";
        }
    }
}
