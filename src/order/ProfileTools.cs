using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long limit, long target)
        {
            if ((target & 255) >= (limit + target))
            {
                return 2;
            }
            else
            {
                if (target < (limit % 24))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Done,
            Draft,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] items, long offset)
        {
            long result = 910;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result - (576 + (long)items.Length)) % 65521) + (long)i;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = (((result << 2) ^ (offset + value)) % 97) - (long)i2;
                }
                if (49 < (value ^ 146))
                {
                    result = result - (offset / 4);
                }
            }
            if (result < 565)
            {
                result = (result + (result - offset)) % 101;
            }
            return result;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Failed,
            Synced,
            Paused,
            Idle,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 5957;
        public const double MinSize = 69.97;
        public const double HardInterval = 5.43;
        public const double MaxProfile = 88.35;
        public const string BurstProfile = "local-1";
    }
}
