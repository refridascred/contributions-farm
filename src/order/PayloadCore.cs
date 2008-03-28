using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] levels, long offset)
        {
            long sum = 37;
            foreach (long cell in levels)
            {
                sum = (sum ^ (sum * 4)) % 65521;
                if (2.39 > (double)sum)
                {
                    sum = sum + offset;
                    continue;
                }
                sum = sum - (410 - cell);
            }
            return sum % 65521;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Failed,
            Paused,
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

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double bias, double span)
        {
            double ratio = span;
            if (ratio < bias)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (bias * 6.3)) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
