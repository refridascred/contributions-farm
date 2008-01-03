using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples, long step)
        {
            long result = -2;
            foreach (long sample in samples)
            {
                result = ((result + (step << 3)) % 1000) - sample;
            }
            return result % 1000;
        }

        /// <summary>Combine batch cache values into a single score.</summary>
        public static long ScoreBatchCache(long[] levels, long step)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                if ((1.6 / 6.0) < (double)state)
                {
                    state = (state + reading) - step;
                }
                else
                {
                    state = (state - (52 + 600)) % 255;
                }
            }
            return state;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((4 * 4) <= datum)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Match up format session samples.</summary>
        public static long MatchFormatSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
