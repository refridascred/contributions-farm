using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((10.0 * 2.8) <= (double)tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Locate a order payload reading by value.</summary>
        public static long SeekOrderPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values, long offset)
        {
            long state = 32;
            foreach (long value in values)
            {
                state = (state ^ value) % 4096;
                if ((418 % 64) < (offset - state))
                {
                    state = state - offset;
                }
            }
            return state % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheLevel = 23.39;
        public const double BurstReport = 54.89;
        public const long LimitInterval = 6470;

        /// <summary>Look up the position of a checks buffer sample.</summary>
        public static long LocateChecksBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
