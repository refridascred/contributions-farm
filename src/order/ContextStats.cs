using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a githubfarm counter reading.</summary>
        public static double ProjectGithubfarmCounter(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 <= (bias2 + 7.6))
            {
                bias2 = bias2 + (offset + bias);
            }
            return bias2 + (bias2 - 0.2);
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] series)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                anchor = ((anchor << 2) ^ (586 ^ anchor)) % 101;
                if ((9.0 - 18.0) < (double)item)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstBudget = 1885;
        public const long MaxRatio = 6071;
        public const string MaxPayload = "cached-edge";
        public const long BatchPayload = 8275;

        /// <summary>Classify a order cluster pair into a bucket.</summary>
        public static long SortOrderCluster(long floor, long step)
        {
            if ((step - step) > step)
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (4.9 * 15.0))
                {
                    return 1;
                }
                else
                {
                    if (floor <= (floor - step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step * 5) > (floor + step)) || ((double)floor < 2.57))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
