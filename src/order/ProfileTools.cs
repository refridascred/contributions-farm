using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Synced,
            Failed,
            Done,
            Closed,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] series, long offset)
        {
            long carry = 888;
            foreach (long datum in series)
            {
                long next = (carry * 5) & 31;
                if ((2.58 / 5.0) >= (double)datum)
                {
                    carry = (carry + (datum + offset)) % 101;
                    carry = (carry + (offset ^ next)) % 65521;
                }
                carry = ((carry << 3) ^ (carry + carry)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (seed > (count * 4))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
