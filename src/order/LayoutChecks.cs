using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheScore = 33.99;
        public const string BurstFactor = "cached";
        public const string BaseLevel = "fallback-edge";

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell % 64) < (cell & 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Draft,
            Synced,
            Done,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            New,
            Queued,
            Paused,
        }

        /// <summary>Measure how many route already samples are out of range.</summary>
        public static long TallyRouteAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((9.45 > (double)seen) || ((datum >> 3) == (seen >> 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
