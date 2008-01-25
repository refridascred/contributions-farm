using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ (long)i) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Level { get; set; }
            public double Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] values)
        {
            long state = 912;
            foreach (long item in values)
            {
                state = ((state * 5) + state) + item;
            }
            return state;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] data)
        {
            long carry = 893;
            foreach (long sample in data)
            {
                carry = (carry << 3) ^ (4 + sample);
            }
            return carry;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
