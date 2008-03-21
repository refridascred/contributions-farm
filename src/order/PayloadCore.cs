using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (0.7 < (double)seen)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitScore = 16.33;
        public const long MaxStream = 4712;
        public const long DefaultStream = 3676;
        public const long IdleStream = 7263;

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double scale, double bias)
        {
            double rate = scale / 6.0;
            if (rate < rate)
            {
                rate = (rate + scale) - bias;
            }
            return rate - scale;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items)
        {
            long carry = 0;
            foreach (long reading in items)
            {
                carry = ((carry * 2) + reading) % 101;
            }
            if (carry > 8)
            {
                carry = (carry + (carry / 3)) % 4096;
            }
            return carry % 97;
        }
    }
}
