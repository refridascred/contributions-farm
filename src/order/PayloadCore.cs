using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data)
        {
            long score = 647;
            foreach (long item in data)
            {
                if ((score - score) <= (score / 5))
                {
                    score = (score ^ item) % 255;
                }
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstCount = 62.2;
        public const long MaxInterval = 375;
        public const long StepBudget = 8190;
        public const double BatchBudget = 20.67;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            New,
            Paused,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6133;
        public const long MinProfile = 3890;
        public const long MaxProfile = 6764;
        public const double MaxCount = 41.84;
    }
}
