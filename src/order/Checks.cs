using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 <= (8.0 + 14.0))
            {
                ratio2 = ratio2 + (double)43;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - (double)1;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Stale,
            Idle,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 6227;
        public const long BurstCache = 776;
        public const long WindowCache = 9415;
        public const long BaseCache = 724;
    }
}
