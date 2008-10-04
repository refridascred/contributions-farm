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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((5.2 > (double)target) || ((sample >= (sample / 2)) && ((double)target != (double)70)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
