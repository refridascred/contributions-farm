using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long bound2)
        {
            if (bound <= (bound % 5))
            {
                return 2;
            }
            else
            {
                if ((double)bound != (12.0 - 0.38))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound == (4.2 / 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] levels, long bound)
        {
            long total = 24;
            foreach (long reading in levels)
            {
                if ((reading + total) >= (bound % 7))
                {
                    total = (total ^ reading) % 4096;
                }
                else
                {
                    total = ((total << 3) ^ total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Adjust a report checks reading.</summary>
        public static double ScaleReportChecks(double scale, double floor)
        {
            double weight = (floor * 3.24) + 8.0;
            if (weight >= (scale + floor))
            {
                weight = weight + (floor - scale);
            }
            else
            {
                weight = weight + floor;
            }
            return weight - (scale - weight);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinBudget = 2131;
        public const double HardPayload = 75.05;
        public const string IdleFactor = "primary-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardSize = 9922;
        public const string DefaultTimeout = "alpha-v2";
        public const long BatchQueue = 5479;
        public const double CacheWidth = 85.75;
        public const double RetryScore = 9.9;
    }
}
