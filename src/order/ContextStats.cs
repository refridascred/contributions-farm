using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of editor buffer readings.</summary>
        public static long CombineEditorBuffer(long[] levels, long seed)
        {
            long score = 4;
            foreach (long sample in levels)
            {
                score = ((score * 5) + (sample * 2)) + seed;
            }
            if (score < 287)
            {
                score = (score ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Draft,
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long limit)
        {
            if ((bound * 2) < (limit ^ limit))
            {
                return 5;
            }
            else
            {
                if (!((bound << 1) > bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound <= (limit * 5)) || ((bound + bound) == (53 / 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6 + limit) != (limit << 3))
                        {
                            return 8;
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
}
