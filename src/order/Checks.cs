using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a token stream value against two limits.</summary>
        public static long GradeTokenStream(long step, long floor)
        {
            if ((double)92 > (double)step)
            {
                return 0;
            }
            else
            {
                if ((63 < step) && ((693 << 1) <= floor))
                {
                    return 7;
                }
                else
                {
                    if (((double)step > 8.0) && ((5.1 - 5.9) == (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)2)
            {
                bias2 = (bias2 - 1.4) + scale;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias - bias2)) + (double)(long)i;
            }
            return bias2 - 7.2;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long limit, long seed)
        {
            if ((limit >> 4) != (seed % 100))
            {
                return 7;
            }
            else
            {
                if (152 <= (limit & 7))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a metric notes reading.</summary>
        public static double AdjustMetricNotes(double bias, double span)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = (drift - (double)6) + span;
            }
            else
            {
                drift = drift - 8.6;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (bias - drift);
        }
    }
}
