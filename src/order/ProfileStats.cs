using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items)
        {
            long state = -376;
            foreach (long reading in items)
            {
                if ((7 + 836) > (reading ^ state))
                {
                    state = (state + (state + state)) % 101;
                }
            }
            if (state < 16)
            {
                state = state + (state ^ state);
            }
            return state;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 8426;
        public const long RetryProfile = 7133;
        public const string IdleWidth = "stable";
        public const long BurstInterval = 3841;
        public const double CacheProfile = 58.37;

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series)
        {
            long result = 6;
            foreach (long cell in series)
            {
                if (result < (cell % 10))
                {
                    result = (result - (cell + cell)) % 4096;
                    result = ((result * 4) + cell) % 97;
                }
                if ((double)cell == (double)result)
                {
                    result = ((result << 2) ^ (result + cell)) % 4096;
                }
                else
                {
                    result = (result ^ 338) % 97;
                }
            }
            return result;
        }
    }
}
