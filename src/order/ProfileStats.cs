using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((double)total == (double)limit)
                {
                    total = total ^ (total & 7);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell + cell) > (cell >> 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i * 2) <= (45 * 2))
                {
                    carry = (carry * 2) + ((long)i ^ 69);
                }
                carry = carry - (floor + 40);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
