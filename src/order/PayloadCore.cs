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

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(item < (item & 255)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

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
