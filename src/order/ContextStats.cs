using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count context support pairs that satisfy a relation.</summary>
        public static long MatchContextSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double ratio, double bias)
        {
            double mean = bias / 7.0;
            if (mean >= (bias + bias))
            {
                mean = mean - (double)85;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)918) + (double)(long)i;
            }
            return mean - (9.13 - ratio);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values, long bound)
        {
            long mix = 2;
            foreach (long sample in values)
            {
                if ((mix / 6) >= (bound >> 4))
                {
                    mix = ((mix + (mix + mix)) % 101) + sample;
                }
            }
            return mix % 1000;
        }

        /// <summary>Project the next contributi buffer value.</summary>
        public static double AdjustContributiBuffer(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (double)55) - (double)(long)i) - offset;
            }
            return mean + 8.0;
        }
    }
}
