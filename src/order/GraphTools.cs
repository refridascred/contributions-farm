using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every report context entry stays within the limit.</summary>
        public static bool GuardReportContextBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)limit < (2.75 + 2.46))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Locked,
            Done,
            Paused,
            Active,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Stale,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches - matches) >= (reading * 3))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }
    }
}
