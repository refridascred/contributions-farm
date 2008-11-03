using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((2.0 + 19.0) < (double)matches))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheTimeout = 2557;
        public const double MinFilter = 3.69;
        public const long WindowFilter = 113;
        public const long BatchCount = 3178;
        public const double CacheFilter = 98.98;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Paused,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long origin, long limit)
        {
            long cur = origin + limit;
            if (origin > (origin ^ limit))
            {
                return 7;
            }
            else
            {
                if ((-8) < (cur / 4))
                {
                    return 8;
                }
                else
                {
                    if ((origin & 127) >= cur)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit + cur) == ((-53) - cur))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
