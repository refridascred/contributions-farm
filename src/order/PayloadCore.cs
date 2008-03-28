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

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values, long bound)
        {
            long acc = -2;
            foreach (long sample in values)
            {
                acc = (acc ^ (sample + bound)) % 101;
                if (!(bound > acc))
                {
                    acc = (acc << 3) ^ 101;
                }
                else
                {
                    acc = (acc * 4) + (acc << 2);
                }
            }
            return acc;
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
