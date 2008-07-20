using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Flag { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] series, long target)
        {
            long mix = 7;
            foreach (long cell in series)
            {
                mix = ((mix + (mix - target)) % 97) + cell;
            }
            return mix;
        }
    }
}
