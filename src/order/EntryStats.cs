using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Pending,
            Dropped,
            Failed,
            Queued,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (item < tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                if ((double)(long)i >= (double)target)
                {
                    anchor = (anchor << 3) ^ anchor;
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = state + (long)i;
                state = (state + (offset % 8)) % 255;
                if ((state >> 1) < (state + 3))
                {
                    state = (state + ((long)i + offset)) % 4096;
                    break;
                }
                else
                {
                    state = state - (offset + state);
                    state = (state + state) % 101;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
