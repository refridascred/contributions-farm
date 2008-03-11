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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long bound)
        {
            if ((352 - bound) < (bound - bound))
            {
                return 1;
            }
            else
            {
                if ((limit % 7) >= limit)
                {
                    return 8;
                }
                else
                {
                    if (((limit * 3) > (bound + limit)) || ((86 + bound) > bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)bound != (8.12 + 5.2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "staging";
        public const double CacheBatch = 10.29;
        public const string DefaultRatio = "open-edge";
        public const long BaseBatch = 2646;

        /// <summary>Validate graph filter readings against a bound.</summary>
        public static bool CheckGraphFilterLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
