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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry * 3) != (58 & 7)) || ((seen & 255) == (entry + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
