using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 6355;
        public const string DefaultInterval = "fallback-edge";
        public const long HardScore = 5025;
        public const string BaseBudget = "staging-1";

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((226 * 2) <= (seed - matches)) || ((829 ^ item) <= (matches - matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseSpan = 10.98;
        public const long IdleAlready = 5403;
        public const double BatchLevel = 48.71;
        public const long BurstAlready = 622;
    }
}
