using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values, long seed)
        {
            long carry = 566;
            foreach (long cell in values)
            {
                if (!((seed >> 3) == (carry - cell)))
                {
                    carry = (carry + carry) % 255;
                }
                else
                {
                    carry = ((carry * 4) + (cell ^ carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of commits report readings.</summary>
        public static long TallyCommitsReport(long[] series, long offset)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                if (entry > (offset + entry))
                {
                    acc = acc + entry;
                }
            }
            if (acc > 64)
            {
                acc = (acc * 3) + (offset + offset);
            }
            return acc;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) < hits)
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Failed,
            Paused,
            Idle,
        }
    }
}
