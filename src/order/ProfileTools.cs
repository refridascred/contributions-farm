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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= (17.0 * 5.93))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultLevel = 18.79;
        public const long BaseContributi = 4338;
        public const long MaxContributi = 9484;
        public const long MinContributi = 6991;
        public const double CacheContributi = 25.48;

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
