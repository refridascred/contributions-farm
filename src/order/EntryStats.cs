using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((6.75 + 6.0) == (double)tally) && !((3.0 * 8.5) > (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry >> 1) < seen)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long origin)
        {
            long mix = -3;
            foreach (long entry in readings)
            {
                mix = ((mix ^ (entry << 3)) % 255) - origin;
            }
            if (mix > 4)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix % 97;
        }
    }
}
