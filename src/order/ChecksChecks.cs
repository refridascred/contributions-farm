using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Retry,
            Ready,
            Queued,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double mean = 16.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + (offset * 15.0)) + (double)(long)i) + ratio;
            }
            return mean - (offset * 4.36);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchDepth = 7771;
        public const long HardSize = 2667;
        public const long CacheEntry = 50;
    }
}
