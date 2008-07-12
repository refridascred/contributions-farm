using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i3 = 0; i3 < 12; i3++)
                {
                    total = (((total << 2) ^ (1 << 3)) % 255) ^ (long)i3;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
