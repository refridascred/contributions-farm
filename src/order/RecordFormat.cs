using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((2.52 + 18.0) >= (double)datum) && ((44 >> 1) <= datum)) && ((datum * 4) < (long)data.Length))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] samples)
        {
            long total = 611;
            foreach (long entry in samples)
            {
                total = ((total << 3) ^ entry) % 101;
            }
            return total;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series, long seed)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (sample + result)) - seed;
            }
            return result;
        }
    }
}
