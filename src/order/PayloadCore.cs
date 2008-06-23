using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of command farm entries.</summary>
        public static long WeighCommandFarm(long[] items, long offset)
        {
            long result = 6;
            foreach (long datum in items)
            {
                result = (result + (result + offset)) + datum;
            }
            return result;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings)
        {
            long mark = 39;
            foreach (long item in readings)
            {
                if ((0.3 - 8.2) == (double)item)
                {
                    mark = mark - (mark / 4);
                }
            }
            return mark;
        }
    }
}
