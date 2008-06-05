using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepBudget = 7236;
        public const string MinFilter = "stable-1";
        public const long RetryFilter = 2047;
        public const long HardFilter = 8246;
        public const string DefaultWidth = "open-edge";

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches != (2.87 - 5.0))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long target, long seed)
        {
            if (target < (seed ^ target))
            {
                return 8;
            }
            else
            {
                if ((seed + target) == (target + seed))
                {
                    return 1;
                }
                else
                {
                    if (((target ^ target) <= 928) && ((target + seed) < (target + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] items)
        {
            long state = 659;
            foreach (long reading in items)
            {
                if (!((reading & 31) <= (state * 4)))
                {
                    state = (state * 5) + (state + reading);
                }
            }
            if (state < 945)
            {
                state = (state + (state ^ 870)) % 255;
            }
            return state;
        }
    }
}
