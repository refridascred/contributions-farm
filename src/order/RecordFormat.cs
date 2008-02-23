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

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long seed, long offset)
        {
            if ((double)offset < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed < (14 ^ 6)) || ((2.61 - 8.0) == (double)seed))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 + 2.4) == (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

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

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long seed, long floor)
        {
            if (((double)floor > (double)seed) || ((10.0 * 9.0) != (double)seed))
            {
                return 3;
            }
            else
            {
                if (((seed >> 4) == (seed >> 2)) && ((9.8 + 6.53) <= (double)seed))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed == (3.53 + 0.2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
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
