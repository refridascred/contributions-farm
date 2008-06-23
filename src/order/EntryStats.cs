using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the report token entries that pass the check.</summary>
        public static long CountReportTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (2 >= sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the window commits series from a seed.</summary>
        public static long IterateWindowCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardScore = "alpha-v2";
        public const string DefaultFactor = "stable";
        public const long SoftStream = 4618;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((((value & 7) <= (value & 1)) && (value < matches)) || !((matches >> 1) == (value - 589)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading <= (reading & 127)) && (39 < (hits % 24)))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
