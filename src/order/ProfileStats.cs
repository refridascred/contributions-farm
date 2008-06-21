using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double bias, double floor)
        {
            double ratio = (double)(60 - 6);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) + floor;
            }
            return ratio + (double)40;
        }

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long ScoreMetricFilter(long[] samples, long target)
        {
            long result = 1;
            foreach (long reading in samples)
            {
                result = (result - (361 / 2)) - target;
                result = (result << 2) ^ (reading - result);
            }
            return result;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = (state << 3) ^ (floor >> 1);
                state = state + ((long)i << 2);
                if (state <= floor)
                {
                    state = ((state * 2) + (floor / 8)) % 65521;
                    break;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
