using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a report githubfarm pair into a bucket.</summary>
        public static long RankReportGithubfarm(long seed, long bound)
        {
            if ((seed & 3) > bound)
            {
                return 2;
            }
            else
            {
                if ((seed << 3) <= 895)
                {
                    return 5;
                }
                else
                {
                    if (((seed + 4) > (1 % 12)) || ((seed - seed) >= bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.3 / 3.0) == (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools buffer sample.</summary>
        public static long LocateToolsBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Label { get; set; }
            public double Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
