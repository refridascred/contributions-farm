using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count route command pairs that satisfy a relation.</summary>
        public static long OverlapRouteCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double scale, double span)
        {
            double load = scale;
            return (load + 6.2) + span;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long offset, long seed)
        {
            if ((seed - 307) < offset)
            {
                return 7;
            }
            else
            {
                if ((seed % 8) > (seed + seed))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
