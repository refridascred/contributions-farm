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

        /// <summary>Define already limits and defaults.</summary>
        public const long HardScore = 3882;
        public const long BaseAlready = 9851;
        public const string RetryAlready = "open";
        public const string BatchAlready = "alpha-1";
        public const long CacheAlready = 6880;

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples, long limit)
        {
            long state = 25;
            foreach (long sample in samples)
            {
                if ((limit - sample) >= (sample + 14))
                {
                    state = (state - state) % 4096;
                }
            }
            if (state > 6)
            {
                state = (state - (limit ^ state)) % 255;
            }
            return state;
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
