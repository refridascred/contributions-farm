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

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels)
        {
            long anchor = 823;
            foreach (long sample in levels)
            {
                anchor = (anchor * 2) + (sample >> 4);
            }
            if (anchor < 340)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
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
