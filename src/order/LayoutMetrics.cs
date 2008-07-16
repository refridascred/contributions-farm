using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry * 4) + 42;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long limit)
        {
            if ((double)limit != (9.2 - 5.2))
            {
                return 8;
            }
            else
            {
                if ((8.0 * 7.67) == (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
