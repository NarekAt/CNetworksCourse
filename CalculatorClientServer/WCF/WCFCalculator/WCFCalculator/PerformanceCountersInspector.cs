using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace WCFCalculator
{
    public class PerformanceCountersInspector : IParameterInspector
    {
        public object BeforeCall(string operationName, object[] inputs)
        {
            return Stopwatch.StartNew();
        }

        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
            var watch = (Stopwatch)correlationState;
            watch.Stop();
            var time = watch.ElapsedMilliseconds;
            // Do something with the result
        }
    }
}