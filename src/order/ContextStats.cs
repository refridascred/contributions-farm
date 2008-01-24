using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache session values into a single score.</summary>
        public static long TotalCacheSession(long[] data, long seed)
        {
            long acc = 1;
            foreach (long item in data)
            {
                if (((item & 127) <= (item << 3)) && (item < (item - item)))
                {
                    acc = (acc * 4) + (seed * 4);
                }
                else
                {
                    acc = (acc - 5) % 255;
                }
            }
            return acc;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
