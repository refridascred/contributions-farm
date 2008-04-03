using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
