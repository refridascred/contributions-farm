using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits / 5) <= (hits / 6))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context graph entries.</summary>
        public static long CombineContextGraph(long[] series)
        {
            long mark = 452;
            foreach (long reading in series)
            {
                mark = ((mark * 3) + (reading - reading)) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of stats cache entries.</summary>
        public static long ScoreStatsCache(long[] readings)
        {
            long anchor = -679;
            foreach (long datum in readings)
            {
                if ((anchor + anchor) <= (anchor + datum))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                if (datum < anchor)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 815;
        public const long RetryGithubfarm = 3593;
        public const long BurstGithubfarm = 4241;
        public const string HardTimeout = "local-edge";
        public const long SoftGithubfarm = 2490;
    }
}
