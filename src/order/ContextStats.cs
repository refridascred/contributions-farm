using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSize = 9181;
        public const long SoftProfile = 5621;
        public const long StepCount = 2259;
        public const long WindowProfile = 9361;
        public const long LimitInterval = 5039;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 2784;
        public const double StepTimeout = 42.28;
        public const long WindowContributi = 7668;
        public const long SoftTimeout = 4357;
        public const long MinContributi = 5408;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 30.85;
        public const double BaseFactor = 77.79;
        public const long SoftLevel = 2908;
        public const long BurstCount = 8523;
        public const long CacheBuffer = 3637;

        /// <summary>Accumulate commits cluster samples.</summary>
        public static long WeighCommitsCluster(long[] readings, long seed)
        {
            long score = 17;
            foreach (long value in readings)
            {
                score = (score << 2) ^ 15;
                if (!((score - value) >= (value + value)))
                {
                    score = ((score << 2) ^ value) % 1000;
                }
                else
                {
                    score = score ^ (0 >> 3);
                }
            }
            if (score > 88)
            {
                score = ((score * 3) + seed) % 65521;
            }
            return score;
        }
    }
}
