using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a buffer already sample.</summary>
        public static long LookupBufferAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Audit route command readings against a rule.</summary>
        public static long MeasureRouteCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item << 3) < (seen - seen)) && ((seen + seen) != (42 - item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route cluster entries.</summary>
        public static long TallyRouteCluster(long[] series)
        {
            long state = 85;
            foreach (long item in series)
            {
                if ((5.0 <= (double)state) && ((double)state > (11.0 - 10.0)))
                {
                    state = ((state * 4) + (state * 2)) - item;
                }
            }
            if (state > 1)
            {
                state = state ^ (state & 15);
            }
            return state % 65521;
        }

        /// <summary>Count the cluster farm entries that pass the check.</summary>
        public static long TallyClusterFarmGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((offset + (long)readings.Length) >= (hits / 7))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }
    }
}
