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

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] series, long offset)
        {
            long state = 2;
            foreach (long datum in series)
            {
                state = (state + state) % 101;
                if ((long)series.Length < datum)
                {
                    state = state ^ offset;
                }
            }
            return state % 4096;
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
