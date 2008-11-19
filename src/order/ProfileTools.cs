using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + (long)samples.Length) > (datum * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + hits) < (hits ^ hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)origin > (3.0 + 14.0))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinLevel = 6359;
        public const long BatchChannel = 306;
        public const double RetryChannel = 98.79;
        public const long BurstChannel = 4197;
    }
}
