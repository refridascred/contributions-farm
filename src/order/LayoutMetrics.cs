using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double offset)
        {
            double mean = (double)(36 + (-82));
            if (mean < (offset - 9.4))
            {
                mean = (mean - (3.0 * 15.0)) - rate;
            }
            return mean + (offset - offset);
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a githubfarm report value against two limits.</summary>
        public static long BucketGithubfarmReport(long offset, long floor)
        {
            long bound = offset ^ floor;
            if (((16 & 15) >= offset) || ((bound - 89) > (offset + offset)))
            {
                return 7;
            }
            else
            {
                if (((double)993 > (double)offset) || ((double)offset != (18.0 * 20.0)))
                {
                    return 5;
                }
                else
                {
                    if ((offset - floor) <= 2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((8.0 * 0.15) == (double)bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
