using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] items)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark + (cell / 8)) % 101) ^ (long)i;
                    mark = (mark << 3) ^ (mark & 3);
                }
                if ((cell << 1) <= ((long)items.Length % 60))
                {
                    mark = mark + (30 / 6);
                }
            }
            if (mark < 22)
            {
                mark = mark ^ (10 >> 3);
            }
            return mark % 97;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((2 * 3) >= entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry & 31) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the stream profile entries that pass the check.</summary>
        public static long MeasureStreamProfileMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((8 + entry) >= (long)levels.Length)
                {
                    count = (count + 3) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((640 >> 2) < cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
