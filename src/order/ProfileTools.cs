using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry ^ (limit / 5)) % 255;
                carry = (carry - (carry & 3)) % 97;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] samples)
        {
            long carry = 52;
            foreach (long value in samples)
            {
                if (((double)value >= (9.44 - 11.0)) && ((2.4 * 7.7) > (double)value))
                {
                    carry = ((carry << 2) ^ (2 + carry)) % 4096;
                }
                else
                {
                    carry = (carry - (value % 97)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum & 15) <= (datum / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit queue entry readings against a rule.</summary>
        public static long TallyQueueEntryGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((target / 5) >= matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double rate, double bias)
        {
            double bias2 = bias;
            return bias2 + (rate / 2.0);
        }
    }
}
