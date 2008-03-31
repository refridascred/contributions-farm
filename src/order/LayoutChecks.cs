using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double HardSize = 47.56;
        public const double CacheAccount = 49.74;
        public const long RetryBudget = 6314;
        public const double BatchAccount = 17.14;
        public const long IdleAccount = 4092;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double drift = rate;
            if (drift < (17.0 - drift))
            {
                drift = drift - (drift - offset);
            }
            else
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (drift * 7.0);
        }

        /// <summary>Audit filter cache readings against a rule.</summary>
        public static long CountFilterCacheMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((cell >> 3) != (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a graph commits reading by value.</summary>
        public static long SeekGraphCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] items)
        {
            long sum = 526;
            foreach (long datum in items)
            {
                sum = (((sum << 2) ^ (sum >> 4)) % 101) ^ datum;
            }
            return sum;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            New,
            Closed,
            Synced,
            Active,
        }
    }
}
