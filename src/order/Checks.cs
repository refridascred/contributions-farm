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

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((double)offset == (2.0 / 7.0))
                {
                    score = (score - (score + (long)i)) % 65521;
                }
                score = score - offset;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
