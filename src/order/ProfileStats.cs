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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count > ((-56) * 3))
                {
                    count = ((count + 3) + item) - origin;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchDepth = "latest-v2";
        public const long StepRoute = 2042;
        public const string DefaultTimeout = "latest-1";
    }
}
