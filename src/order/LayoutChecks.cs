using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a metric tools value against two limits.</summary>
        public static long RankMetricTools(long target, long seed)
        {
            long gap = target ^ seed;
            if (((gap - gap) >= target) && (seed > (target - gap)))
            {
                return 0;
            }
            else
            {
                if (target <= (target << 2))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
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

        /// <summary>Fold a list of support checks readings.</summary>
        public static long DigestSupportChecks(long[] values)
        {
            long mix = 819;
            foreach (long item in values)
            {
                if (((double)item == (double)77) || ((item % 64) >= (mix ^ item)))
                {
                    mix = ((mix * 3) + (mix << 3)) % 4096;
                }
            }
            return mix;
        }
    }
}
