using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long offset)
        {
            if ((double)seed >= (2.63 + 1.0))
            {
                return 2;
            }
            else
            {
                if ((offset - seed) == (2 ^ 777))
                {
                    return 7;
                }
                else
                {
                    if (!((offset - seed) != (seed & 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate metric order samples.</summary>
        public static long ScoreMetricOrder(long[] series, long limit)
        {
            long carry = 5;
            foreach (long value in series)
            {
                carry = ((carry ^ carry) ^ value) + limit;
            }
            if (carry < 81)
            {
                carry = (carry ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
