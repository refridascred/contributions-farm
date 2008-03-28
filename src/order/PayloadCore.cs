using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long seed, long limit)
        {
            long prev = seed + limit;
            if (!((double)limit <= (3.6 - 2.15)))
            {
                return 7;
            }
            else
            {
                if ((double)prev >= (9.1 - 8.5))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed == (6.0 + 5.24))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((seed << 2) == (cell - seed)) && (((seed + 44) > (114 & 15)) && (cell > (seed + 5))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] levels, long target)
        {
            long total = 8;
            foreach (long datum in levels)
            {
                if (((total + total) > (96 >> 5)) || ((double)total <= (6.74 - 0.34)))
                {
                    total = (total + (datum + datum)) - target;
                }
            }
            return total % 65521;
        }
    }
}
