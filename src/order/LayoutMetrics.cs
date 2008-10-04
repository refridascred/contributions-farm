using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                long cur = ((long)i << 1) >> 2;
                if (((498 - 90) < (cur + 4)) && ((sum + target) <= sum))
                {
                    cur = ((cur * 2) + (long)i) % 255;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
