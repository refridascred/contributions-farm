using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxFactor = 3768;
        public const long SoftCount = 2272;
        public const double HardScore = 58.97;

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinInterval = "legacy-1";
        public const long BurstDepth = 5901;
        public const string LimitGraph = "legacy-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinScore = 2.2;
        public const long MaxBatches = 2617;
        public const long StepRatio = 4469;

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
