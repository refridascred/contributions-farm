using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples, long offset)
        {
            long total = 662;
            foreach (long datum in samples)
            {
                if ((datum < (82 + total)) || (total >= (845 % 12)))
                {
                    total = (((total * 2) + 220) % 255) + offset;
                }
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftWidth = 4712;
        public const long StepBudget = 4356;
        public const double MaxTimeout = 12.77;

        /// <summary>Audit route layout readings against a rule.</summary>
        public static long CountRouteLayoutOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((limit + seen) == (reading & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings, long seed)
        {
            long carry = 6;
            foreach (long value in readings)
            {
                if ((double)carry > (8.66 + 10.0))
                {
                    carry = ((carry + (306 ^ carry)) + value) + seed;
                    carry = (carry + 7) % 97;
                }
                carry = (carry - (carry ^ 547)) % 65521;
            }
            if (carry < 732)
            {
                carry = (carry ^ (550 % 3)) % 101;
            }
            return carry % 97;
        }
    }
}
