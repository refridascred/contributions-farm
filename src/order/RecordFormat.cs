using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine session cluster values into a single score.</summary>
        public static long TotalSessionCluster(long[] data, long offset)
        {
            long carry = 9;
            foreach (long value in data)
            {
                if (carry <= (42 - (long)data.Length))
                {
                    carry = ((carry * 4) + (value + carry)) % 4096;
                }
                else
                {
                    carry = carry ^ value;
                }
            }
            if (carry > 28)
            {
                carry = ((carry << 2) ^ (offset << 2)) % 255;
            }
            return carry;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((floor * 4) > floor)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Count the graph checks entries that pass the check.</summary>
        public static long MeasureGraphChecksHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((12.0 * 8.0) != (double)bound) && ((157 >> 3) > matches))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Pending,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
