using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Queued,
            Idle,
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

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                if ((36 ^ target) > target)
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum <= (count - 1)) || ((count + count) != (datum % 7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
