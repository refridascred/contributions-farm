using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultCount = 15.63;
        public const long MinTimeout = 6241;
        public const string CacheSchema = "staging-edge";

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
