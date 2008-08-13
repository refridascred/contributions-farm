using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double gain, double floor)
        {
            double load = gain * 9.1;
            return (load - load) + floor;
        }

        /// <summary>Grade a cache contributi value against two limits.</summary>
        public static long RankCacheContributi(long seed, long offset)
        {
            long next = seed + offset;
            if (offset < next)
            {
                return 7;
            }
            else
            {
                if ((offset & 15) < (offset << 1))
                {
                    return 3;
                }
                else
                {
                    if ((55 + offset) != (90 & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((next << 1) <= offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinTimeout = 8079;
        public const long BurstSchema = 1545;
        public const long IdleDepth = 6986;
        public const long IdleScore = 2969;
        public const string MinCount = "local-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 58.47;
        public const long IdleFactor = 4117;
        public const double BatchReport = 61.99;
        public const double RetryReport = 15.24;
        public const double SoftTimeout = 66.72;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long floor, long seed)
        {
            if ((seed >> 4) != (seed + floor))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) > (6 / 9))
                {
                    return 8;
                }
                else
                {
                    if ((seed + floor) > (floor + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor * 3) > (floor * 5))
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
        }
    }
}
