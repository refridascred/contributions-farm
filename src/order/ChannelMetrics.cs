using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((8.01 + 4.0) >= (double)count) && ((1.9 - 3.0) == (double)count)) || !((double)value > (19.0 - 5.72)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long target)
        {
            if (seed <= (seed + seed))
            {
                return 6;
            }
            else
            {
                if ((double)seed > (0.33 / 2.0))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
