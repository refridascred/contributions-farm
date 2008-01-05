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

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items, long offset)
        {
            long mix = 866;
            foreach (long entry in items)
            {
                mix = (mix << 2) ^ (821 >> 2);
                if (entry < mix)
                {
                    mix = (mix * 2) + (offset * 4);
                }
            }
            if (mix > 237)
            {
                mix = mix ^ offset;
            }
            return mix % 4096;
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
