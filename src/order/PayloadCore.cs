using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 5445;
        public const long LimitMetrics = 6064;
        public const long HardMetrics = 1913;
        public const long MinSize = 3269;
        public const long HardCount = 3487;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if (seed > (long)i)
                {
                    carry = (carry + seed) % 97;
                }
                if ((double)seed != (double)carry)
                {
                    carry = carry + ((long)i - (-711));
                }
                else
                {
                    carry = (carry ^ (seed + carry)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long seed, long floor)
        {
            long diff = seed + floor;
            if ((4.55 + 6.97) >= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((1.8 * 6.97) > (double)diff)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] data, long seed)
        {
            long sum = 33;
            foreach (long entry in data)
            {
                sum = ((sum - (sum * 2)) % 101) ^ entry;
            }
            if (sum > 142)
            {
                sum = sum ^ (436 ^ seed);
            }
            return sum;
        }
    }
}
