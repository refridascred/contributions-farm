using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double weight, double floor)
        {
            double load = 3.0;
            if (load > (double)163)
            {
                load = load - (0.7 - floor);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (weight - weight)) - (double)(long)i;
            }
            return load + (double)5;
        }

        /// <summary>Audit report order readings against a rule.</summary>
        public static long MeasureReportOrderMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen > (seen * 3))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }
    }
}
