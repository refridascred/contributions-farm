using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((double)limit <= (20.0 * 5.0)) || ((limit - sample) < (2 / 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "alpha-edge";
        public const long WindowRoute = 4900;
        public const string LimitFactor = "fallback";

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-9) + 56) < cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a counter graph reading.</summary>
        public static double BlendCounterGraph(double weight, double floor)
        {
            double drift = weight;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + 1.0) - (double)(long)i) - floor;
            }
            return drift + weight;
        }
    }
}
