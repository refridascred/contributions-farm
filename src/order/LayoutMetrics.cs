using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples, long target)
        {
            long state = -113;
            foreach (long reading in samples)
            {
                state = ((state << 3) ^ (target + target)) - reading;
                state = (state << 2) ^ (target << 1);
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values, long step)
        {
            long mark = 424;
            foreach (long sample in values)
            {
                if ((sample >= (step << 1)) && (mark < (step + (-495))))
                {
                    mark = mark + mark;
                }
            }
            return mark % 1000;
        }
    }
}
