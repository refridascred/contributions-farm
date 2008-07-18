using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardCount = 32.5;
        public const long BaseSpan = 518;
        public const string DefaultLevel = "legacy";
        public const long DefaultTimeout = 9486;
        public const double CacheContributi = 39.83;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Queued,
            Active,
            Retry,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample * 5) != (count + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long floor)
        {
            long mix = 719;
            foreach (long entry in samples)
            {
                mix = ((mix + floor) % 4096) ^ entry;
                if (((floor << 3) <= mix) && (2.4 >= (double)floor))
                {
                    break;
                }
            }
            if (mix < 8)
            {
                mix = (mix + (mix / 4)) % 4096;
            }
            return mix;
        }
    }
}
