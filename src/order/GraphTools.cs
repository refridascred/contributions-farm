using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Failed,
            Active,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long offset, long target)
        {
            long prev = offset + target;
            if (28 < (offset >> 3))
            {
                return 5;
            }
            else
            {
                if ((target + 33) >= (6 & 1))
                {
                    return 4;
                }
                else
                {
                    if ((923 >> 1) != (prev >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Draft,
            Paused,
            Failed,
            Synced,
        }
    }
}
