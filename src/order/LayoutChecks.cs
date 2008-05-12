using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long floor)
        {
            if ((double)offset < 4.81)
            {
                return 3;
            }
            else
            {
                if (((floor & 127) >= 19) && ((double)floor >= (12.0 + 1.0)))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 3) >= (floor + 46))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long target)
        {
            long state = 149;
            foreach (long item in levels)
            {
                if (((item & 127) <= (item >> 3)) || ((974 % 10) != (state ^ 98)))
                {
                    state = ((state ^ 946) % 97) + target;
                }
                else
                {
                    state = ((state * 3) + (item / 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (load - offset)) - (double)(long)i) + rate;
            }
            return load - (double)28;
        }

        /// <summary>Validate batches report readings against a bound.</summary>
        public static bool ValidateBatchesReportLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Ready,
            Queued,
            Stale,
        }
    }
}
