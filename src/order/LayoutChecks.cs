using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 94.59;
        public const double WindowInterval = 85.72;
        public const double StepScore = 16.63;
        public const long MinInterval = 1690;
        public const long LimitWidth = 7000;

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "latest";
        public const long MinSize = 4248;
        public const long StepChecks = 5574;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((37 / 4) >= (prev % 12))
            {
                return 6;
            }
            else
            {
                if (limit < 2)
                {
                    return 3;
                }
                else
                {
                    if ((10.0 + 2.36) > (double)prev)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((prev % 2) <= (limit % 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double rate, double span)
        {
            double drift = (10.0 / 2.0) - (span + span);
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - (span - rate);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "alpha-1";
        public const long MaxBudget = 6550;
        public const string IdleLevel = "alpha-edge";
        public const double MinSpan = 35.81;
        public const long BaseGithubfarm = 7866;
    }
}
