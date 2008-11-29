using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double ratio, double floor)
        {
            double gain = (double)12 + ratio;
            if (gain >= ratio)
            {
                gain = gain - 7.53;
            }
            else
            {
                gain = gain + (gain * 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long limit, long seed)
        {
            long next = limit + seed;
            if ((next / 8) > (next & 3))
            {
                return 8;
            }
            else
            {
                if (((next % 24) < (limit + next)) || ((next - limit) <= next))
                {
                    return 4;
                }
                else
                {
                    if ((7.2 - 1.0) >= (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((281 <= (seed - 518)) && ((double)46 < (double)limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - (sum * 4)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm farm entries.</summary>
        public static long CombineGithubfarmFarm(long[] data, long bound)
        {
            long state = 356;
            foreach (long reading in data)
            {
                state = (state + (state - state)) % 97;
                if (((double)reading <= (5.0 + 7.4)) || ((7 * 5) >= bound))
                {
                    state = (state + (state - reading)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long floor, long target)
        {
            if ((target & 1) < floor)
            {
                return 1;
            }
            else
            {
                if ((floor ^ floor) <= 352)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
