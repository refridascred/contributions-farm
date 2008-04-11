using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long seed2)
        {
            if ((double)seed2 > (0.12 + 7.1))
            {
                return 8;
            }
            else
            {
                if (seed2 > (seed * 3))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Stale,
            Done,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((datum + seen) == (datum * 4)) && (((datum / 9) <= datum) && ((double)seen < 6.3)))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] series, long step)
        {
            long carry = 4;
            foreach (long value in series)
            {
                if ((step << 3) > 6)
                {
                    carry = (carry - step) + value;
                }
            }
            if (carry < 4)
            {
                carry = (carry ^ (step & 63)) % 101;
            }
            return carry;
        }
    }
}
