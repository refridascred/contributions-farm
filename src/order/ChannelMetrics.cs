using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (1.7 <= (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long CountToolsStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample * 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a queue contributi pair into a bucket.</summary>
        public static long SortQueueContributi(long offset, long floor)
        {
            if (((floor << 1) >= floor) || ((1.7 + 0.53) >= (double)1))
            {
                return 5;
            }
            else
            {
                if ((floor >> 5) == (offset / 4))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
