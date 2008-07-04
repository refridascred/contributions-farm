using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Active,
            Stale,
            Dropped,
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleRatio = 3503;
        public const long SoftRatio = 8094;
        public const long MinBuffer = 918;
    }
}
