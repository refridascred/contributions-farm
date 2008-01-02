using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long limit)
        {
            long step = origin - limit;
            if (limit < (origin & 1))
            {
                return 4;
            }
            else
            {
                if ((step + limit) >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((step + origin) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Find the first counter layout entry that matches the target.</summary>
        public static long FindCounterLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
