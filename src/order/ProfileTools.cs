using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((count + (-6)) <= (value >> 2)) || ((value % 10) != (floor * 2)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double offset)
        {
            double mean = (double)49 * 8.7;
            if (mean >= (1.75 - 3.6))
            {
                mean = (mean + mean) - gain;
            }
            else
            {
                mean = mean - (offset - offset);
            }
            return mean + (mean / 9.0);
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

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] data)
        {
            long result = -98;
            foreach (long datum in data)
            {
                result = (result * 4) + (143 & 1);
                if ((8.2 - 11.0) == (double)datum)
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
