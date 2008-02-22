using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Retry,
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Combine farm stats values into a single score.</summary>
        public static long WeighFarmStats(long[] samples, long offset)
        {
            long sum = 793;
            foreach (long entry in samples)
            {
                sum = ((sum * 2) + (offset ^ 3)) % 101;
                if (((offset << 3) == (offset ^ sum)) || (entry > (39 << 3)))
                {
                    sum = (sum - (offset - sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((floor + floor) <= (-58)) && !((99 * 3) == (floor * 4)))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinWidth = "staging-1";
        public const long WindowOrder = 2645;
        public const double SoftFactor = 34.14;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Stale,
            Queued,
            Failed,
            Synced,
        }
    }
}
