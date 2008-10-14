using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double load = bias2;
            if (load > (load * 5.0))
            {
                load = (load - (double)517) - bias;
            }
            return load - bias2;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits / 6) > hits)
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
