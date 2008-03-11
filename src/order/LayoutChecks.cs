using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long origin2)
        {
            long step = origin ^ origin2;
            if ((origin - origin) >= 17)
            {
                return 0;
            }
            else
            {
                if (step <= (origin2 % 10))
                {
                    return 6;
                }
                else
                {
                    if (9.3 <= (double)origin2)
                    {
                        return 2;
                    }
                    else
                    {
                        if (403 >= origin2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "staging";
        public const double CacheBatch = 10.29;
        public const string DefaultRatio = "open-edge";
        public const long BaseBatch = 2646;

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "staging-edge";
        public const long LimitSupport = 2207;
        public const double WindowSupport = 62.22;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((535 % 24) > (bound ^ bound))
            {
                return 2;
            }
            else
            {
                if ((bound & 63) != (bound >> 1))
                {
                    return 0;
                }
                else
                {
                    if (!((bound & 31) < bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.8 + 11.0) <= (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double rate, double bias)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (gain - bias)) + (double)(long)i;
            }
            return gain + (19.0 + rate);
        }
    }
}
