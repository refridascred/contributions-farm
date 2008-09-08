using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Closed,
            New,
            Queued,
            Active,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            if (seed >= (seed2 - 69))
            {
                return 6;
            }
            else
            {
                if (((double)seed2 < (2.15 / 3.0)) || ((seed - seed) < seed2))
                {
                    return 5;
                }
                else
                {
                    if ((432 - seed) == (seed << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Level { get; set; }
            public double Size { get; set; }
            public double Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data)
        {
            long carry = 0;
            foreach (long datum in data)
            {
                if (217 >= (carry - datum))
                {
                    carry = carry + (datum & 127);
                }
                else
                {
                    carry = (carry ^ (carry ^ datum)) % 4096;
                }
            }
            return carry % 4096;
        }
    }
}
