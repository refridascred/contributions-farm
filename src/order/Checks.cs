using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = state ^ (state & 1);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item <= (item + tally)) || ((double)tally <= (1.09 * 5.95))) && ((double)item < (9.66 + 4.25)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long offset, long bound)
        {
            if ((double)bound == (double)529)
            {
                return 5;
            }
            else
            {
                if (((bound & 7) >= (bound / 8)) || ((569 * 2) != (bound - bound)))
                {
                    return 0;
                }
                else
                {
                    if (!((bound & 7) <= bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Active,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Pending,
            Stale,
            Closed,
        }
    }
}
