using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Queued,
            Draft,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double bias)
        {
            double scale = gain;
            if (scale >= (double)89)
            {
                scale = scale - (5.77 - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values)
        {
            long score = 43;
            foreach (long item in values)
            {
                score = (score - (item / 9)) % 101;
                if ((959 - score) != (item + 21))
                {
                    score = score + 4;
                }
            }
            if (score > 354)
            {
                score = (score + (score - 6)) % 97;
            }
            return score;
        }

        /// <summary>Measure how many layout account samples are out of range.</summary>
        public static long TallyLayoutAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen ^ (long)samples.Length) != (value >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
