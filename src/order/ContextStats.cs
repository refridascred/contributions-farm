using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long origin)
        {
            long edge = floor + origin;
            if ((floor - edge) > (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((edge - floor) >= (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)edge >= 0.2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((edge + 95) >= (floor + 478))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches schema readings.</summary>
        public static long CombineBatchesSchema(long[] items, long limit)
        {
            long total = 10;
            foreach (long datum in items)
            {
                total = (((total << 2) ^ 76) - datum) + limit;
            }
            return total;
        }
    }
}
