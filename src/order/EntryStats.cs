using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 9996;
        public const long MaxRoute = 8377;
        public const long BurstWidth = 9467;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a already command value against two limits.</summary>
        public static long BucketAlreadyCommand(long bound, long origin)
        {
            if ((double)origin <= (1.8 - 4.4))
            {
                return 6;
            }
            else
            {
                if ((7 / 5) <= (origin - origin))
                {
                    return 1;
                }
                else
                {
                    if ((bound <= (origin * 2)) || ((bound + 493) <= (bound & 127)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin < (1.9 - 6.99))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long limit)
        {
            long prev = target ^ limit;
            if ((limit << 3) != (prev + limit))
            {
                return 7;
            }
            else
            {
                if ((limit << 3) <= (prev << 1))
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
