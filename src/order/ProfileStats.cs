using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a route githubfarm figure with a bias.</summary>
        public static double ProjectRouteGithubfarm(double gain, double bias)
        {
            double bias2 = bias;
            return (bias2 - (double)88) + gain;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long bound, long limit)
        {
            if ((limit & 31) > 1)
            {
                return 5;
            }
            else
            {
                if ((double)limit < (2.8 - 4.34))
                {
                    return 3;
                }
                else
                {
                    if ((limit * 2) < (limit + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((11.0 / 8.0) < (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
