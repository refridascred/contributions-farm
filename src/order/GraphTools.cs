using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            Stale,
            New,
            Failed,
        }

        /// <summary>Accumulate contributi support samples.</summary>
        public static long TotalContributiSupport(long[] readings)
        {
            long carry = 1;
            foreach (long entry in readings)
            {
                if (!(carry <= 325))
                {
                    carry = (((carry * 5) + carry) % 4096) + entry;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Count { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every session stream entry stays within the limit.</summary>
        public static bool VerifySessionStreamRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long bound)
        {
            long diff = offset - bound;
            if ((diff >> 5) < (offset ^ diff))
            {
                return 2;
            }
            else
            {
                if (((diff - diff) > (offset - 64)) && ((offset - bound) < bound))
                {
                    return 3;
                }
                else
                {
                    if (offset >= (offset << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((230 ^ bound) <= (diff ^ diff))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
