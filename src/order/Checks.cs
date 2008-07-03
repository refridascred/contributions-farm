using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Failed,
            Synced,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Dropped,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Compare every pair of context session readings.</summary>
        public static long OverlapContextSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Stale,
            Synced,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long seed, long limit)
        {
            if (limit <= seed)
            {
                return 4;
            }
            else
            {
                if ((9.0 < (double)seed) || ((seed - limit) <= (limit % 100)))
                {
                    return 2;
                }
                else
                {
                    if ((1.4 + 10.0) <= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
