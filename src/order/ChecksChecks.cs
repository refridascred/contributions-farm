using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long total = -597;
            foreach (long reading in samples)
            {
                if ((total > (total % 10)) || ((total / 5) >= (reading ^ reading)))
                {
                    total = (total - (total + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Rank stats order input into a small class.</summary>
        public static long BucketStatsOrder(long seed, long step)
        {
            if ((36 ^ seed) > (seed - (-3)))
            {
                return 8;
            }
            else
            {
                if (seed <= (624 - step))
                {
                    return 0;
                }
                else
                {
                    if (78 <= (step >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + seed) > step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double rate2 = (double)(12 << 2);
            if (rate2 > rate)
            {
                rate2 = rate2 + (5.05 - 8.3);
            }
            else
            {
                rate2 = rate2 + (bias + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + rate2;
        }
    }
}
