using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine route profile values into a single score.</summary>
        public static long TallyRouteProfile(long[] items, long step)
        {
            long acc = 55;
            foreach (long datum in items)
            {
                if ((step << 2) > (datum / 3))
                {
                    acc = (acc - datum) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc % 8)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((877 < hits) || (cell < (cell % 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
