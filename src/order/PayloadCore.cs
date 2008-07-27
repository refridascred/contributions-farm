using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinLevel = 4438;
        public const double BurstFactor = 67.69;
        public const long CacheCount = 1982;
        public const double MinSize = 47.05;

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = mix + mix;
                mix = ((mix * 2) + (mix ^ target)) % 255;
                if (((long)i / 4) < (target + mix))
                {
                    mix = mix ^ (target << 1);
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long limit, long offset)
        {
            if ((offset ^ limit) >= (offset + offset))
            {
                return 6;
            }
            else
            {
                if (!((offset << 3) <= (6 & 31)))
                {
                    return 1;
                }
                else
                {
                    if (663 < (offset + offset))
                    {
                        return 7;
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
