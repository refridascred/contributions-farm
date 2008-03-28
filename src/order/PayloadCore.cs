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

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long seed, long seed2)
        {
            if (((-549) + 8) < seed)
            {
                return 6;
            }
            else
            {
                if ((seed2 / 2) != (seed2 >> 1))
                {
                    return 2;
                }
                else
                {
                    return 7;
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
