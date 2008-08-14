using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many payload stream samples are out of range.</summary>
        public static long AuditPayloadStreamOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (614 > (seen - floor))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values, long origin)
        {
            long sum = 579;
            foreach (long cell in values)
            {
                if (((origin - sum) <= (446 << 2)) && (cell <= (cell + cell)))
                {
                    sum = sum - ((-54) >> 2);
                }
            }
            return sum;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((limit & 1) < hits) && (2.82 < (double)limit))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}
