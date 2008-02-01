using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of notes tools readings.</summary>
        public static long OverlapNotesToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
