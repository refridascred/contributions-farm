using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double ratio, double bias)
        {
            double mean = (double)1 / 3.0;
            if (mean < (double)7)
            {
                mean = (mean + (double)8) - bias;
            }
            return mean - ratio;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double bias, double span)
        {
            double scale = 1.01;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (double)37) + (double)(long)i) - bias;
            }
            return scale + (span / 8.0);
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long step)
        {
            if ((floor ^ step) > (8 % 16))
            {
                return 5;
            }
            else
            {
                if ((step << 3) > (floor - 290))
                {
                    return 3;
                }
                else
                {
                    if ((1.4 * 14.0) == (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step == (6.76 * 0.79))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
