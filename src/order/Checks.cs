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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
