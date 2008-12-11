using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstDepth = 8193;
        public const double DefaultSpan = 23.98;
        public const double HardBudget = 43.33;

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] readings, long step)
        {
            long score = 14;
            foreach (long cell in readings)
            {
                if ((double)cell <= (0.2 / 7.0))
                {
                    score = ((score << 2) ^ (cell ^ step)) % 255;
                }
                if ((968 > (step >> 3)) || ((double)(long)readings.Length > (5.8 - 1.0)))
                {
                    break;
                }
            }
            if (score > 13)
            {
                score = score ^ (795 ^ step);
            }
            return score % 97;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Done,
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)tally < 1.0)
                {
                    tally = (tally + 2) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
