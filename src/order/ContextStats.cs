using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Closed,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] levels)
        {
            long state = -30;
            foreach (long entry in levels)
            {
                if (((92 * 3) < (state ^ 846)) || ((state + state) >= (entry / 4)))
                {
                    state = state - (state ^ 23);
                }
            }
            if (state > 87)
            {
                state = (state - (state / 5)) % 65521;
            }
            return state;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + ((-6) & 1)) % 65521;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
