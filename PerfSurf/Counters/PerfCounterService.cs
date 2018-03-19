using System.Collections.Generic;
using System.Linq;

namespace PerfSurf.Counters
{
    public class PerfCounterService
    {
        private List<PerfCounterWrapper> perfCounters;

        public PerfCounterService()
        {
            perfCounters = new List<PerfCounterWrapper>();
            perfCounters.Add(new PerfCounterWrapper("Processor", "Processor", "% Processor Time", "_Total"));
            perfCounters.Add(new PerfCounterWrapper("Paging", "Memory", "Pages/sec"));
            perfCounters.Add(new PerfCounterWrapper("PhysicalDisk", "% Disk Time", "_Total"));
        }

        public dynamic GetResults()
        {
            return perfCounters.Select(c => new { name = c.Name, value = c.Value });
        }
    }
}
