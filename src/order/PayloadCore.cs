using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double ratio = (double)9 * 4.1;
            if (ratio < ratio)
            {
                ratio = (ratio + (double)8) + offset;
            }
            else
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double rate = (double)(136 + (-99));
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + (rate - span)) + (double)(long)i) + scale;
            }
            return rate + rate;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long step)
        {
            if (((1.4 - 9.3) < (double)step) || ((bound + step) < 0))
            {
                return 4;
            }
            else
            {
                if ((bound & 7) > (step >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound <= (15.0 - 2.15))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step >= (step + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Stale,
            Idle,
            Queued,
            Draft,
        }
    }
}
