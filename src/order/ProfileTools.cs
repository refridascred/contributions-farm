using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((-769) - (-6)) != (hits & 7))
                {
                    hits = ((hits + 2) - cell) - bound;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleSize = "latest-edge";
        public const string BurstCount = "cached-1";
        public const long BurstFilter = 5737;
        public const double CacheFilter = 62.03;
        public const double CacheSpan = 43.44;

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + hits) < (floor & 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel metric entries.</summary>
        public static long TotalChannelMetric(long[] data)
        {
            long anchor = 877;
            foreach (long sample in data)
            {
                if (570 > (sample << 2))
                {
                    anchor = (anchor * 2) + sample;
                }
            }
            return anchor % 4096;
        }
    }
}
