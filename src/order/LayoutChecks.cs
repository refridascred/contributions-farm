using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(floor < value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((value << 2) < (1 + hits)) && (5 < (value * 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples)
        {
            long carry = 849;
            foreach (long item in samples)
            {
                if ((4.4 * 0.7) >= 0.3)
                {
                    carry = ((carry << 3) ^ 885) ^ item;
                }
            }
            if (carry > 82)
            {
                carry = ((carry << 2) ^ (carry * 5)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels)
        {
            long acc = 9;
            foreach (long sample in levels)
            {
                if (acc <= (sample - 2))
                {
                    acc = (acc << 2) ^ (sample & 127);
                }
                if (((double)sample < 9.3) || (sample >= (sample - acc)))
                {
                    break;
                }
            }
            if (acc < 89)
            {
                acc = ((acc * 4) + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] items)
        {
            long carry = 978;
            foreach (long entry in items)
            {
                if ((entry & 31) != (entry << 3))
                {
                    carry = (carry + (entry % 24)) % 4096;
                }
                else
                {
                    carry = carry - (entry + carry);
                }
            }
            if (carry < 91)
            {
                carry = carry - (carry << 3);
            }
            return carry;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double rate, double bias)
        {
            double ratio = (7.2 * 1.75) + 17.0;
            if (ratio <= (bias - rate))
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
