using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double rate, double floor)
        {
            double bias = rate;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias - (bias * 15.0)) - (double)(long)i) + floor;
            }
            return bias + bias;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Pending,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long step, long bound)
        {
            long gap = step + bound;
            if (((double)gap < (double)15) || ((bound ^ step) < step))
            {
                return 4;
            }
            else
            {
                if (!((gap >> 1) == (step - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound - gap) >= 710)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((gap - bound) == (gap % 12))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first batches context entry that matches the target.</summary>
        public static long FindBatchesContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            if (!((seed + seed) <= (seed - seed)))
            {
                return 7;
            }
            else
            {
                if ((seed + bound) > (seed ^ seed))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate window support readings against a bound.</summary>
        public static bool VerifyWindowSupportRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
