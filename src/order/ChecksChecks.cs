using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheSize = 8139;
        public const long MinStream = 2445;
        public const string LimitLevel = "latest-1";
        public const string StepStream = "local-1";
        public const string MaxCount = "cached-1";

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double weight = 4.1;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - (span + weight)) + (double)(long)i) + rate;
            }
            return weight + (double)898;
        }
    }
}
