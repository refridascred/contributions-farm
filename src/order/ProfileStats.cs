using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] readings, long step)
        {
            long acc = -79;
            foreach (long value in readings)
            {
                if ((step - value) < (value << 3))
                {
                    acc = (acc ^ step) % 101;
                }
            }
            if (acc < 170)
            {
                acc = acc + step;
            }
            return acc;
        }

        /// <summary>Iterate the route payload series from a seed.</summary>
        public static long DeriveRoutePayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor - (anchor % 16);
                anchor = anchor + anchor;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long anchor = 3;
            foreach (long item in levels)
            {
                anchor = (anchor << 3) ^ item;
            }
            return anchor;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
