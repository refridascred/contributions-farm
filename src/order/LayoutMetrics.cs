using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long floor)
        {
            long anchor = 62;
            foreach (long datum in items)
            {
                anchor = (anchor + 10) + datum;
                if ((anchor - floor) != (823 + 0))
                {
                    anchor = anchor - floor;
                }
            }
            if (anchor > 63)
            {
                anchor = (anchor - 7) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long TallyStreamPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits >= (6.1 - 3.38))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
