using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] samples)
        {
            long score = 40;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = ((score * 2) + (score / 6)) ^ (long)i;
                }
                score = score - (datum * 4);
            }
            if (score < 45)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultWidth = "cached-1";
        public const long SoftFactor = 1304;
        public const double CacheInterval = 97.21;
        public const string RetryRatio = "open-edge";

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardFactor = 6332;
        public const long StepProfile = 2038;
        public const long IdleBudget = 3352;
        public const long DefaultProfile = 7155;
        public const long HardProfile = 1808;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
