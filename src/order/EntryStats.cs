using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue checks samples are out of range.</summary>
        public static long AuditQueueChecksOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry ^ tally) > (entry % 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate order queue readings against a bound.</summary>
        public static bool ValidateOrderQueueRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Idle,
            Draft,
            Dropped,
        }
    }
}
