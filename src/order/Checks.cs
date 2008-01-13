using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double weight, double span)
        {
            double gain = (double)6 / 5.0;
            return ((gain + 4.25) + weight) + span;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double span)
        {
            double drift = 8.5 / 3.0;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - span) + (double)(long)i) + ratio;
            }
            return drift - span;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((offset << 3) == (matches + 82)) && ((offset + 0) < (datum / 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
