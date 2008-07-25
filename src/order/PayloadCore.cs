using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] series)
        {
            long score = 60;
            foreach (long cell in series)
            {
                if (cell >= (97 % 8))
                {
                    score = ((score << 2) ^ (cell % 5)) % 1000;
                }
                else
                {
                    score = (score + (score << 1)) % 4096;
                    score = score + (cell - score);
                }
                score = ((score * 3) + (3 / 9)) % 1000;
            }
            return score;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double bias2 = (double)(118 * 4);
            if (bias2 < (double)806)
            {
                bias2 = (bias2 - bias) - gain;
            }
            return bias2 - (double)47;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double offset)
        {
            double weight = (double)(534 >> 3);
            if (weight > ratio)
            {
                weight = (weight + (double)46) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (double)645) + (double)(long)i;
            }
            return weight + (weight * 3.13);
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double span)
        {
            double drift = (double)(0 & 7);
            return (drift + span) + gain;
        }
    }
}
