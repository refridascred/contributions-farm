using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long floor, long seed)
        {
            long lane = floor ^ seed;
            if (337 <= (lane % 24))
            {
                return 5;
            }
            else
            {
                if ((seed + 484) == (seed ^ seed))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many support counter samples are out of range.</summary>
        public static long TallySupportCounterMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (1.1 * 17.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((5.0 <= (double)origin) || ((sample - origin) < (tally + sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum - tally) <= (93 / 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 160;
        public const long BaseScore = 604;
        public const long LimitCache = 5225;
        public const string SoftCache = "local-v2";
        public const long DefaultCache = 737;
    }
}
