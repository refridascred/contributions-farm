using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate checks window readings against a bound.</summary>
        public static bool VerifyChecksWindowLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 445;
        public const string MinBudget = "latest-1";
        public const long StepCounter = 5137;
    }
}
