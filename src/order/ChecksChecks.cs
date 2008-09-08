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

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double load = span;
            return (load - 7.0) + gain;
        }
    }
}
