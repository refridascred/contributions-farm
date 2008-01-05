using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitDepth = 18.91;
        public const string HardScore = "open-v2";
        public const long SoftLevel = 1144;
        public const long HardWidth = 1990;

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data)
        {
            long carry = -35;
            foreach (long entry in data)
            {
                carry = carry + (carry + entry);
            }
            if (carry < 189)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 25.12;
        public const double BatchTimeout = 79.55;
        public const double LimitBuffer = 34.06;

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally <= (double)item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
