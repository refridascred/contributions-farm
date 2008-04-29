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

        /// <summary>Count layout profile pairs that satisfy a relation.</summary>
        public static long CompareLayoutProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
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
