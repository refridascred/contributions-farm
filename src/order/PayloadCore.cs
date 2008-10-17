using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double mean = ratio;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)(long)i) + floor;
            }
            return mean + mean;
        }

        /// <summary>Derive the next counter report value from a seed.</summary>
        public static long DeriveCounterReport(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((step * 5) >= (step >> 3)))
                {
                    score = (score - (long)i) % 101;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double rate, double floor)
        {
            double mean = (double)((-17) + 862);
            if (mean >= (rate - mean))
            {
                mean = (mean - (double)1) + floor;
            }
            else
            {
                mean = mean - (double)(-9);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)683) + (double)(long)i;
            }
            return mean - (double)39;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long bound)
        {
            long bound2 = offset + bound;
            if (!((559 % 5) <= (bound << 2)))
            {
                return 3;
            }
            else
            {
                if ((530 + 2) == (bound + offset))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 / 9) == (offset - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
