using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits ^ item) >= item)
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Measure how many order channel samples are out of range.</summary>
        public static long TallyOrderChannelMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry >> 1) < (matches & 15))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((941 * 5) > (value + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Closed,
            Active,
            Done,
            Queued,
        }
    }
}
