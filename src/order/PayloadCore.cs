using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((6.59 - 2.74) <= (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((double)value < 15.0) && ((value + value) < (hits % 5)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
