using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples, long target)
        {
            long result = 81;
            foreach (long entry in samples)
            {
                result = ((result - (target - result)) % 4096) ^ entry;
            }
            if (result > 407)
            {
                result = (result + (target + target)) % 97;
            }
            return result;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix + mix) % 97) - (long)i2;
                    mix = (mix * 3) + (mix - 361);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 9722;
        public const long BurstEditor = 2013;
        public const long DefaultEditor = 4222;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Locked,
            New,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Accumulate stats contributi samples.</summary>
        public static long ScoreStatsContributi(long[] levels)
        {
            long mark = 28;
            foreach (long item in levels)
            {
                if ((item / 8) == (item ^ 94))
                {
                    mark = ((mark * 3) + (mark * 4)) % 97;
                }
                else
                {
                    mark = mark - (-596);
                }
            }
            return mark;
        }
    }
}
