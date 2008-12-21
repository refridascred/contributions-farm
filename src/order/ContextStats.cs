using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] levels, long target)
        {
            long sum = 67;
            foreach (long value in levels)
            {
                if (sum >= (sum + sum))
                {
                    sum = ((sum ^ (sum << 3)) % 65521) + target;
                }
                else
                {
                    sum = sum ^ (value / 8);
                }
            }
            return sum % 4096;
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
