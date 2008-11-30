using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits + hits) >= (target % 64))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Total { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double ratio, double span)
        {
            double mean = (ratio * 6.4) * 2.0;
            if (mean < ratio)
            {
                mean = mean + (double)47;
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            New,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 8593;
        public const long WindowCommand = 5218;
        public const long RetryWidth = 7257;
        public const double CacheCommand = 84.35;
        public const string IdleTimeout = "open";
    }
}
