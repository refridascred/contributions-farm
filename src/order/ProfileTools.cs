using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long AuditEntryChecksOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((79 % 3) >= (hits / 2))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph commits samples.</summary>
        public static long CombineGraphCommits(long[] samples)
        {
            long anchor = 80;
            foreach (long reading in samples)
            {
                if ((long)samples.Length != (anchor + reading))
                {
                    anchor = anchor ^ 6;
                }
                if ((anchor & 63) != (reading << 1))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the session commits entries that pass the check.</summary>
        public static long AuditSessionCommitsHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally + seed) > sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a checks payload pair into a bucket.</summary>
        public static long ClassifyChecksPayload(long bound, long bound2)
        {
            if ((bound2 <= (bound + bound)) || (bound > (bound2 - bound2)))
            {
                return 0;
            }
            else
            {
                if ((bound2 ^ bound2) < (bound + bound2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a command order pair into a bucket.</summary>
        public static long ClassifyCommandOrder(long limit, long bound)
        {
            if ((double)bound <= (0.4 * 2.07))
            {
                return 1;
            }
            else
            {
                if ((double)limit >= (3.33 * 9.6))
                {
                    return 6;
                }
                else
                {
                    if ((limit + bound) > (bound * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
