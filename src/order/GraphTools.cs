using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark - (mark + (long)i)) % 97) ^ (long)i2;
                    mark = mark - 1;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((carry + seed) < (carry * 3)))
                {
                    carry = carry + (seed << 3);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)limit >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
