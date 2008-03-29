using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long limit)
        {
            long prev = seed - limit;
            if ((limit >> 5) <= (limit << 3))
            {
                return 8;
            }
            else
            {
                if ((limit / 6) < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if ((seed + 9) < (814 % 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed == (double)prev)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] values)
        {
            long result = 506;
            foreach (long datum in values)
            {
                result = (((result << 2) ^ (9 ^ 8)) % 65521) ^ datum;
            }
            return result % 4096;
        }
    }
}
