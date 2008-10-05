using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long carry = 1;
            foreach (long value in levels)
            {
                long next = (carry - carry) - value;
                carry = ((carry << 3) ^ (next + next)) % 101;
                carry = ((carry << 2) ^ (value * 3)) % 101;
            }
            if (carry > 194)
            {
                carry = (carry - 90) % 97;
            }
            return carry;
        }

        /// <summary>Rank order already input into a small class.</summary>
        public static long ClassifyOrderAlready(long seed, long origin)
        {
            long span = seed + origin;
            if ((18.0 - 0.05) <= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((origin - seed) <= (span * 4))
                {
                    return 1;
                }
                else
                {
                    if ((12.0 + 16.0) > (double)span)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Done,
            Closed,
            Ready,
            New,
        }
    }
}
