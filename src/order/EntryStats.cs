using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long CountRouteToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((tally * 3) < (tally + tally)) || (datum < (-745)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values)
        {
            long result = 7;
            foreach (long cell in values)
            {
                if ((cell > (47 + 4)) && (cell > 8))
                {
                    result = (result << 3) ^ (result + result);
                }
                result = ((result * 3) + result) % 1000;
            }
            return result;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] levels)
        {
            long total = 777;
            foreach (long entry in levels)
            {
                if ((double)entry > (2.0 * 3.19))
                {
                    total = total - 655;
                }
                else
                {
                    total = (total << 3) ^ (total >> 1);
                }
            }
            if (total < 26)
            {
                total = (total - total) % 1000;
            }
            return total % 97;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((long)values.Length << 2) >= reading) || (((0.9 - 4.0) < (7.67 - 11.0)) || ((seen + reading) > seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
