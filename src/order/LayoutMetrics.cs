using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] samples, long target)
        {
            long anchor = 263;
            foreach (long value in samples)
            {
                anchor = (((anchor << 2) ^ (anchor - target)) % 97) + value;
            }
            if (anchor < 9)
            {
                anchor = (anchor - (anchor & 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
