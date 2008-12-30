using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values, long origin)
        {
            long anchor = 575;
            foreach (long value in values)
            {
                anchor = (anchor * 4) + (anchor % 24);
                if (!((6 - value) >= origin))
                {
                    anchor = (anchor * 3) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a account route reading by value.</summary>
        public static long SeekAccountRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
