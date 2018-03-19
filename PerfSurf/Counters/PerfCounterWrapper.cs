using System.Diagnostics;

namespace PerfSurf.Counters
{
    public class PerfCounterWrapper
    {
        public string Name { get; set; }

        private PerformanceCounter perfCounter;

        public float Value
        {
            get => perfCounter.NextValue();
        }

        public PerfCounterWrapper(string name, string category, string counter, string instance = "")
        {
            perfCounter = new PerformanceCounter(category, counter, instance, readOnly: true);
            Name = name;
        }
    }
}
