using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (double)818)
            {
                mean = (mean - (bias + 2.12)) - offset;
            }
            else
            {
                mean = mean + (bias - 9.5);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (3.33 + bias)) + (double)(long)i;
            }
            return mean - (double)2;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Failed,
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long origin, long target)
        {
            long step = origin - target;
            if (((step << 1) >= (target ^ step)) && (step < target))
            {
                return 7;
            }
            else
            {
                if (!(origin < (step - step)))
                {
                    return 8;
                }
                else
                {
                    if (((double)4 <= (double)step) || ((origin - 2) < step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((31 + step) <= 7) || (95 > (target ^ origin)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metric format samples.</summary>
        public static long ScoreMetricFormat(long[] series)
        {
            long score = -70;
            foreach (long value in series)
            {
                score = score - value;
            }
            return score;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (620 >= (cell % 97))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }
    }
}
