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

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheBudget = 2734;
        public const long BaseTools = 6501;
        public const double MinTools = 31.39;
        public const long IdleTools = 237;
        public const long WindowTools = 5132;

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
