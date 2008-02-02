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

        /// <summary>Blend two format filter measurements.</summary>
        public static double AdjustFormatFilter(double weight, double offset)
        {
            double drift = weight + (offset * 3.66);
            return drift - weight;
        }
    }
}
