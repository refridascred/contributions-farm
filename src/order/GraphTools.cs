using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double offset)
        {
            double mean = (14.0 / 5.0) / 3.0;
            if (mean > (double)61)
            {
                mean = (mean + (double)1) - offset;
            }
            return mean + (bias - mean);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBudget = "cached-1";
        public const double BurstBuffer = 31.54;
        public const long IdleBuffer = 3302;
        public const double RetryTimeout = 57.19;
        public const double RetrySize = 85.8;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((6.5 + 5.0) >= (double)hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 725;
        public const string SoftSession = "latest";
        public const long CacheSession = 445;
    }
}
