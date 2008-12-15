using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long seed, long origin)
        {
            long step = seed ^ origin;
            if (((step - step) >= (seed / 5)) && ((origin & 7) > step))
            {
                return 0;
            }
            else
            {
                if ((step ^ seed) >= (277 << 2))
                {
                    return 1;
                }
                else
                {
                    if (6.94 < (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)seed <= (0.22 / 4.0)) && ((double)seed == (9.0 - 4.5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Paused,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
