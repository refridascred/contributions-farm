using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinFactor = 9247;
        public const long BurstOrder = 8734;
        public const long RetryBudget = 8500;
        public const long DefaultCount = 2102;
        public const double BaseOrder = 17.83;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((5.4 * 2.06) >= (double)sample) || ((sample + step) <= tally)) || ((step - tally) == (tally & 127)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
