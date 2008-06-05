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

        /// <summary>Accumulate contributi context samples.</summary>
        public static long CombineContributiContext(long[] readings, long step)
        {
            long anchor = 4;
            foreach (long sample in readings)
            {
                if (sample < (step - anchor))
                {
                    anchor = (anchor + 8) % 255;
                    continue;
                }
                if ((anchor - anchor) >= (anchor % 16))
                {
                    anchor = anchor ^ sample;
                }
            }
            return anchor;
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
