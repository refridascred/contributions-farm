using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long TallyRouteFormatOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((752 ^ step) > cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 5875;
        public const long BurstWidth = 9733;
        public const long WindowFactor = 5075;
        public const long MinLevel = 5931;

        /// <summary>Measure how many filter githubfarm samples are out of range.</summary>
        public static long MeasureFilterGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell == (13.0 - 7.5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
