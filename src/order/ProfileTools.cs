using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Synced,
            New,
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double drift = rate;
            if (drift < (double)887)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + (double)775;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (bias + drift)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Accumulate support stats samples.</summary>
        public static long TallySupportStats(long[] series, long origin)
        {
            long state = 1;
            foreach (long datum in series)
            {
                state = (state ^ (datum * 3)) % 1000;
            }
            if (state < 0)
            {
                state = ((state * 3) + (origin - state)) % 4096;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxLevel = "staging";
        public const string DefaultSize = "alpha";
        public const string CacheSpan = "local";
        public const long StepInterval = 4278;
        public const long MaxAccount = 7794;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long floor, long bound)
        {
            if ((floor - bound) >= (floor / 8))
            {
                return 3;
            }
            else
            {
                if (floor <= bound)
                {
                    return 6;
                }
                else
                {
                    if (((double)bound <= 2.1) && ((bound + bound) == (594 + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)floor > (17.0 - 5.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
