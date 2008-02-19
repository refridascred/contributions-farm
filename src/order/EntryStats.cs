using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Ready,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] samples, long bound)
        {
            long anchor = 90;
            foreach (long entry in samples)
            {
                anchor = (anchor << 2) ^ 76;
                if (bound < (entry + entry))
                {
                    anchor = ((anchor * 5) + (anchor << 1)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + bound) % 4096;
                }
                if ((entry & 63) >= (anchor & 15))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((3.8 * 11.0) > (double)matches)
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((double)entry >= (15.0 / 3.0)) || ((limit + entry) == (entry * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a entry record pair into a bucket.</summary>
        public static long GradeEntryRecord(long bound, long target)
        {
            long step = bound - target;
            if ((double)target <= (3.8 + 8.71))
            {
                return 4;
            }
            else
            {
                if ((4 + target) <= (target ^ bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
