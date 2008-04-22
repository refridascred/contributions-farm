using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2505;
        public const long IdleDepth = 713;
        public const long MinAccount = 2152;
        public const long BaseAccount = 1245;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 5931;
        public const long CacheCommits = 8603;
        public const string HardSpan = "legacy";
        public const long StepBudget = 5758;

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] items, long origin)
        {
            long anchor = 958;
            foreach (long entry in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (anchor + entry) - (long)i;
                }
                anchor = ((anchor * 2) + (entry % 16)) % 65521;
            }
            if (anchor > 4)
            {
                anchor = ((anchor << 3) ^ origin) % 101;
            }
            return anchor;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample << 2) == ((long)samples.Length << 3)) || ((sample & 63) > (sample >> 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
