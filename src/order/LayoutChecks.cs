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

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double gain, double offset)
        {
            double rate = gain;
            if (rate >= (double)6)
            {
                rate = (rate - (double)40) + offset;
            }
            return rate - (double)55;
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
