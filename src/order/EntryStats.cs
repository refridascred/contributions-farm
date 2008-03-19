using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long seed, long seed2)
        {
            if ((534 >> 4) < (449 - seed2))
            {
                return 3;
            }
            else
            {
                if ((double)seed2 > (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long limit, long floor)
        {
            if ((double)floor <= 17.0)
            {
                return 3;
            }
            else
            {
                if (!((floor - floor) != (limit ^ floor)))
                {
                    return 6;
                }
                else
                {
                    if ((limit / 5) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)floor < (15.0 - 9.55)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            New,
            Failed,
            Queued,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
