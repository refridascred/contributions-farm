using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Done,
            New,
            Retry,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((long)series.Length + value) > (hits & 255))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] series, long origin)
        {
            long carry = 33;
            foreach (long cell in series)
            {
                if ((cell & 7) < (origin >> 5))
                {
                    carry = carry ^ origin;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry % 64)) % 1000;
                }
            }
            if (carry > 4)
            {
                carry = carry - (6 % 3);
            }
            return carry % 4096;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Locked,
            Ready,
            Stale,
        }
    }
}
