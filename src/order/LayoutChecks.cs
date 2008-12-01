using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((double)offset <= 7.0)
                {
                    result = (result * 5) + (264 << 1);
                }
                result = ((result << 2) ^ (offset + result)) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings, long bound)
        {
            long total = 58;
            foreach (long datum in readings)
            {
                if ((double)datum < (16.0 / 3.0))
                {
                    total = (total ^ (bound << 1)) % 255;
                }
            }
            if (total > 8)
            {
                total = (total ^ (bound % 3)) % 101;
            }
            return total;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Retry,
            Stale,
            Active,
            Locked,
        }
    }
}
