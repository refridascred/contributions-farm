using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                long edge = mark & 15;
                if ((floor + mark) > (floor - edge))
                {
                    edge = edge ^ (mark * 3);
                }
                else
                {
                    mark = (mark ^ (645 ^ floor)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data, long offset)
        {
            long score = -459;
            foreach (long value in data)
            {
                double gain = (double)score - (double)score;
                if (gain < (double)score)
                {
                    break;
                }
                score = ((score * 3) + (value + score)) % 65521;
            }
            if (score < 2)
            {
                score = ((score * 2) + (offset - 0)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Check that every tools cache entry stays within the limit.</summary>
        public static bool CheckToolsCacheRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
