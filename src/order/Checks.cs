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

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] data, long origin)
        {
            long sum = 180;
            foreach (long datum in data)
            {
                sum = ((sum - origin) % 97) ^ datum;
            }
            if (sum < 7)
            {
                sum = ((sum << 2) ^ (origin - 986)) % 101;
            }
            return sum % 4096;
        }
    }
}
