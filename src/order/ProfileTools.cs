using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count buffer contributi pairs that satisfy a relation.</summary>
        public static long PairBufferContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "cached-edge";
        public const long SoftRatio = 2963;
        public const string SoftWindow = "latest-edge";
        public const long IdleWindow = 376;

        /// <summary>Audit stats command readings against a rule.</summary>
        public static long MeasureStatsCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((5 + value) > (value << 2)) && ((3 >> 2) >= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine commits token values into a single score.</summary>
        public static long TotalCommitsToken(long[] readings)
        {
            long mark = -966;
            foreach (long entry in readings)
            {
                if (!((double)entry < 1.4))
                {
                    mark = (mark ^ (entry ^ entry)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Count the metric format entries that pass the check.</summary>
        public static long CountMetricFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((20.0 / 4.0) == (double)tally) || ((tally & 1) < (cell * 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
