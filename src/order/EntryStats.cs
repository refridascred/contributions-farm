using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Draft,
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Retry,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((entry >> 2) > 68) && ((5.04 - 9.36) >= (double)tally)) || ((7.1 / 4.0) != (double)entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Paused,
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (count > cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
