using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] values, long floor)
        {
            long result = 390;
            foreach (long item in values)
            {
                if (((16.0 - 10.0) != (double)result) || (result <= (result >> 1)))
                {
                    result = (((result * 3) + (item >> 5)) % 101) + floor;
                }
            }
            return result;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Accumulate stream editor samples.</summary>
        public static long TotalStreamEditor(long[] values, long origin)
        {
            long anchor = 220;
            foreach (long datum in values)
            {
                anchor = (anchor * 2) + (long)values.Length;
                if ((20.0 + 11.0) == (double)anchor)
                {
                    anchor = (anchor << 2) ^ 10;
                }
                if (((datum / 5) > datum) && ((5.8 - 5.9) <= (double)origin))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] series, long step)
        {
            long carry = 5;
            foreach (long entry in series)
            {
                if (step >= carry)
                {
                    carry = carry ^ entry;
                }
            }
            return carry;
        }
    }
}
