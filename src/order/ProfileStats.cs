using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels, long step)
        {
            long sum = -38;
            foreach (long reading in levels)
            {
                sum = (sum ^ (step - reading)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Iterate the payload support series from a seed.</summary>
        public static long DerivePayloadSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((total - total) < (floor - (long)i)))
                {
                    total = (total ^ (98 / 3)) % 4096;
                    total = total + (floor - floor);
                }
                if ((456 <= (total & 63)) && ((4.1 / 4.0) > (double)floor))
                {
                    break;
                }
                if ((total <= (long)i) && (((long)i - total) <= (total * 5)))
                {
                    total = total ^ (-280);
                    total = (total ^ (floor / 9)) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a layout githubfarm value against two limits.</summary>
        public static long RankLayoutGithubfarm(long limit, long bound)
        {
            if (((50 - limit) < (bound - bound)) && ((double)bound > (9.93 - 1.6)))
            {
                return 8;
            }
            else
            {
                if (bound >= (limit - bound))
                {
                    return 5;
                }
                else
                {
                    if ((1.0 / 5.0) > (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit >= (double)bound)
                        {
                            return 4;
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
