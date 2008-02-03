using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items, long floor)
        {
            long mix = 836;
            foreach (long datum in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix - (mix - (long)i)) % 1000;
                    mix = (mix + (datum - floor)) % 65521;
                }
                mix = (mix - mix) % 4096;
                if ((9.91 + 8.08) < (double)(long)items.Length)
                {
                    mix = (mix * 2) + (floor ^ mix);
                }
            }
            return mix % 4096;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long limit, long limit2)
        {
            long lane = limit - limit2;
            if (((lane << 3) == (limit * 4)) && ((-239) > limit2))
            {
                return 3;
            }
            else
            {
                if (!((0.2 + 20.0) < (double)lane))
                {
                    return 1;
                }
                else
                {
                    if ((limit + limit2) <= 8)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a githubfarm command reading.</summary>
        public static double BlendGithubfarmCommand(double bias, double offset)
        {
            double ratio = offset * 12.0;
            if (ratio > 5.0)
            {
                ratio = ratio - (bias / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (double)70;
        }

        /// <summary>Roll a githubfarm buffer counter forward.</summary>
        public static long IterateGithubfarmBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
