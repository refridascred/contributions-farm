using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine checks account values into a single score.</summary>
        public static long FoldChecksAccount(long[] samples)
        {
            long score = 70;
            foreach (long entry in samples)
            {
                score = ((score << 3) ^ (entry + entry)) % 97;
                score = ((score * 3) + (entry + 8)) % 101;
            }
            return score;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchDepth = "latest-v2";
        public const long StepRoute = 2042;
        public const string DefaultTimeout = "latest-1";
    }
}
