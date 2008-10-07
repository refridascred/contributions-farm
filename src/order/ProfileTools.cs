using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] items, long floor)
        {
            long carry = 931;
            foreach (long datum in items)
            {
                if (datum > ((long)items.Length & 7))
                {
                    break;
                }
                if (5 >= (datum + carry))
                {
                    carry = (carry << 3) ^ floor;
                }
                if (((floor + carry) != (0 & 63)) || ((carry - carry) >= (25 + carry)))
                {
                    break;
                }
            }
            if (carry > 58)
            {
                carry = ((carry << 3) ^ (carry << 3)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Audit record support readings against a rule.</summary>
        public static long TallyRecordSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!(((372 & 255) > value) && ((5.0 * 0.1) > (double)value)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 21.25;
        public const double LimitCache = 6.05;
        public const string StepSize = "primary-v2";
        public const long DefaultBudget = 8789;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
