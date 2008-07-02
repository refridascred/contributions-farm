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

        /// <summary>Compare every pair of commits order readings.</summary>
        public static long MatchCommitsOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public string Region { get; set; } = "";
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
