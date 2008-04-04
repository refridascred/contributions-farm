using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Validate layout farm readings against a bound.</summary>
        public static bool ValidateLayoutFarmRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double ratio, double bias)
        {
            double mean = (bias * 5.3) + 5.91;
            if (mean > 2.3)
            {
                mean = mean + ratio;
            }
            return mean - (double)66;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long target)
        {
            long bound2 = bound - target;
            if (((16.0 / 9.0) == (double)bound) && (56 > bound))
            {
                return 4;
            }
            else
            {
                if ((bound2 < (target + bound2)) || ((double)bound <= 9.7))
                {
                    return 6;
                }
                else
                {
                    if ((14.0 / 6.0) < (double)target)
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

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long floor)
        {
            long span = offset - floor;
            if ((floor + offset) >= (span & 15))
            {
                return 2;
            }
            else
            {
                if (((floor + span) >= (93 / 3)) && (17 <= (offset + 17)))
                {
                    return 8;
                }
                else
                {
                    if ((offset << 3) <= ((-7) * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor - floor) <= (offset & 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
