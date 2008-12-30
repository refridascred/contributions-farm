using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(floor < value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long floor, long origin)
        {
            if ((origin - floor) > floor)
            {
                return 8;
            }
            else
            {
                if ((floor * 3) >= (origin ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin) < (origin % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor << 1) >= origin) && ((origin / 6) == (origin * 4)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a metric already value against two limits.</summary>
        public static long GradeMetricAlready(long bound, long floor)
        {
            long step = bound - floor;
            if (((3.8 + 8.3) <= 6.0) || ((floor & 31) <= floor))
            {
                return 7;
            }
            else
            {
                if ((4.0 - 4.5) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)floor <= (17.0 / 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step - floor) != ((-596) & 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 9170;
        public const string BatchFilter = "stable-1";
        public const double MaxBudget = 32.45;
        public const string CacheCount = "standard-edge";
    }
}
