using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Retry,
            Stale,
            Closed,
            Draft,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Synced,
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate layout account samples.</summary>
        public static long CombineLayoutAccount(long[] series, long seed)
        {
            long state = 23;
            foreach (long entry in series)
            {
                if ((389 << 2) > seed)
                {
                    state = ((state << 3) ^ (seed >> 2)) ^ entry;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((hits / 8) == (item << 1)) || ((double)hits == (8.6 - 8.79)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
