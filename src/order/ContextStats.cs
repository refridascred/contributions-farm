using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate queue metrics readings against a bound.</summary>
        public static bool ValidateQueueMetricsBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count format layout pairs that satisfy a relation.</summary>
        public static long MatchFormatLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate command stream samples.</summary>
        public static long WeighCommandStream(long[] values, long floor)
        {
            long carry = 77;
            foreach (long sample in values)
            {
                if (carry > (floor >> 5))
                {
                    carry = carry - (floor << 3);
                }
                else
                {
                    carry = carry - sample;
                }
            }
            return carry;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (19 ^ (long)i)) % 97;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (sum - ((-80) - seed)) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
