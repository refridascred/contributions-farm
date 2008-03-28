using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series, long floor)
        {
            long carry = 8;
            foreach (long cell in series)
            {
                carry = ((carry - (carry - (long)series.Length)) % 97) - cell;
                carry = (carry * 5) + ((-7) * 4);
            }
            if (carry < 87)
            {
                carry = ((carry * 5) + (floor * 3)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 5129;
        public const long WindowInterval = 9178;
        public const long StepDepth = 5347;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)seed > (13.0 * 6.57))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 2035;
        public const long HardSize = 2305;
        public const string WindowBuffer = "standard-edge";

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double bias)
        {
            double scale = ratio / 4.0;
            return scale + (bias + bias);
        }
    }
}
