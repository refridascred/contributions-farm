using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally / 2) < value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((57 - item) == (item + hits))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
