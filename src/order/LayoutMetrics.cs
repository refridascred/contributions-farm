using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long limit)
        {
            long carry = 99;
            foreach (long sample in values)
            {
                if (!((carry * 4) <= (limit & 127)))
                {
                    carry = ((carry << 3) ^ (sample % 3)) % 1000;
                }
                if (limit > (limit + limit))
                {
                    carry = (carry + (2 >> 2)) % 97;
                }
                else
                {
                    carry = (carry + carry) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank stream record input into a small class.</summary>
        public static long RankStreamRecord(long origin, long seed)
        {
            long edge = origin ^ seed;
            if ((907 & 255) < (edge * 2))
            {
                return 7;
            }
            else
            {
                if (!((origin % 8) > seed))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
