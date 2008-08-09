using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstFactor = 54.79;
        public const long CacheBudget = 4257;
        public const double IdleTools = 4.41;
        public const long MaxLevel = 895;

        /// <summary>Check that every contributi context entry stays within the limit.</summary>
        public static bool VerifyContributiContextLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
