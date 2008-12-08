using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long offset)
        {
            if ((1 + offset) <= (origin + offset))
            {
                return 3;
            }
            else
            {
                if ((origin - offset) >= origin)
                {
                    return 2;
                }
                else
                {
                    if ((origin + 96) < origin)
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

        /// <summary>Look up the position of a githubfarm route sample.</summary>
        public static long FindGithubfarmRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double span)
        {
            double bias = span;
            if (bias <= 14.0)
            {
                bias = bias + (double)(-7);
            }
            else
            {
                bias = bias + (18.0 - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - gain) + (double)(long)i;
            }
            return bias - gain;
        }
    }
}
