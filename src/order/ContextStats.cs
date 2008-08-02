using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = (state - state) % 255;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long target)
        {
            long state = 869;
            foreach (long entry in values)
            {
                if ((13.0 * 3.7) > (double)target)
                {
                    state = ((state * 5) + state) ^ entry;
                }
                else
                {
                    state = (state * 3) + state;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Ready,
            Retry,
            Locked,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((tally << 1) > sample))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }
    }
}
