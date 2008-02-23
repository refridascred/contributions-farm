using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double load = bias;
            if (load < (gain / 7.0))
            {
                load = load + (bias / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - (double)402;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 3233;
        public const long WindowSize = 3105;
        public const long HardCache = 3233;
        public const long IdleCount = 335;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long offset, long floor)
        {
            if ((offset & 63) != (offset % 5))
            {
                return 2;
            }
            else
            {
                if (((offset + floor) <= 68) || ((offset + floor) < (floor * 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset == (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6 / 8) == (offset % 100))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long bound)
        {
            if (5.44 <= (double)floor)
            {
                return 1;
            }
            else
            {
                if (((double)floor != (double)bound) || (floor < 9))
                {
                    return 3;
                }
                else
                {
                    if (floor > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound & 3) < (bound - bound)) && ((double)bound != (4.0 / 5.0)))
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
    }
}
