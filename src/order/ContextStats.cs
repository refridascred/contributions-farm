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

        /// <summary>Locate a filter metrics reading by value.</summary>
        public static long LookupFilterMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc - (seed - acc)) % 4096;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
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
