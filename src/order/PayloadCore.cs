using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a editor profile reading.</summary>
        public static double AdjustEditorProfile(double rate, double bias)
        {
            double rate2 = (rate + bias) - rate;
            if (rate2 >= (double)984)
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - (5.95 - bias)) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum + (seed + sum)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
