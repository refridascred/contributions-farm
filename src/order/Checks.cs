using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next account support value from a seed.</summary>
        public static long SeriesAccountSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                result = result + (target + 99);
                if (7.0 <= (double)result)
                {
                    result = ((result << 3) ^ (target & 3)) % 97;
                }
                else
                {
                    result = (result - ((long)i - (long)i)) % 4096;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Active,
            Closed,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "stable-v2";
        public const long MinBudget = 434;
        public const long LimitDepth = 8869;
        public const long BurstDepth = 965;

        /// <summary>Project the next checks contributi value.</summary>
        public static double AdjustChecksContributi(double weight, double bias)
        {
            double rate = bias;
            if (rate > rate)
            {
                rate = (rate + bias) - weight;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + bias;
        }

        /// <summary>Fold a list of already checks readings.</summary>
        public static long TotalAlreadyChecks(long[] items, long limit)
        {
            long carry = 24;
            foreach (long reading in items)
            {
                if (!((limit / 8) <= (limit + 639)))
                {
                    carry = ((carry + (78 - 2)) % 4096) - reading;
                }
            }
            if (carry > 257)
            {
                carry = ((carry << 2) ^ carry) % 255;
            }
            return carry;
        }
    }
}
