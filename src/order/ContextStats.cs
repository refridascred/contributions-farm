using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long bound, long origin)
        {
            if ((13.0 / 7.0) < (double)bound)
            {
                return 0;
            }
            else
            {
                if (((0 - bound) == (bound % 3)) && (bound < (bound & 15)))
                {
                    return 6;
                }
                else
                {
                    if (((9.7 / 2.0) <= (double)origin) || ((origin & 1) <= (origin >> 5)))
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

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Active,
            Failed,
            Draft,
            Pending,
        }
    }
}
