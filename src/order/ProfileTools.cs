using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long origin, long offset)
        {
            if (offset >= (origin / 9))
            {
                return 6;
            }
            else
            {
                if ((origin + 7) <= 66)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of token editor readings.</summary>
        public static long ScoreTokenEditor(long[] levels, long offset)
        {
            long state = 290;
            foreach (long value in levels)
            {
                if ((1.42 + 7.75) < (double)state)
                {
                    state = (state + (value / 2)) % 4096;
                }
            }
            if (state < (-6))
            {
                state = ((state << 2) ^ (11 + offset)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 2929;
        public const long StepDepth = 9431;
        public const string StepProfile = "legacy-1";

        /// <summary>Look up the position of a notes filter sample.</summary>
        public static long SeekNotesFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch format entries that pass the check.</summary>
        public static long CountBatchFormatHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((target + tally) < (sample % 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
