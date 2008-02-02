using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix << 3) ^ ((long)i + mix);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix ^ (limit % 3)) % 97) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long step, long limit)
        {
            if ((6 >= (limit ^ limit)) && ((step % 12) < limit))
            {
                return 2;
            }
            else
            {
                if (336 > (limit - step))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank githubfarm route input into a small class.</summary>
        public static long BucketGithubfarmRoute(long seed, long seed2)
        {
            long delta = seed - seed2;
            if (((0 % 60) >= (seed2 ^ seed)) || ((seed2 - seed2) >= (6 << 1)))
            {
                return 4;
            }
            else
            {
                if ((7.36 / 6.0) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed2 << 2) <= (seed2 - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)delta < (4.57 + 2.7)) || (4.0 > (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
