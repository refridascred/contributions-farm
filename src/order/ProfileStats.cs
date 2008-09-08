using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] readings)
        {
            long carry = -75;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (((carry << 2) ^ (carry & 255)) % 255) + (long)i;
                }
                if ((double)(long)readings.Length != (4.0 / 4.0))
                {
                    carry = (carry << 3) ^ entry;
                }
            }
            if (carry > 443)
            {
                carry = (carry << 3) ^ (carry - carry);
            }
            return carry % 4096;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double bias2 = ratio;
            return (bias2 - bias2) + bias;
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long item in samples)
            {
                carry = ((carry - (long)samples.Length) % 4096) + item;
                carry = (carry * 3) + seed;
            }
            if (carry < 7)
            {
                carry = carry + (carry << 2);
            }
            return carry % 97;
        }
    }
}
