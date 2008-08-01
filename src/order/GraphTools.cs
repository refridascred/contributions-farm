using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long seed)
        {
            long offset2 = offset + seed;
            if (offset2 <= (seed + offset2))
            {
                return 2;
            }
            else
            {
                if (1.9 >= (4.8 - 2.1))
                {
                    return 7;
                }
                else
                {
                    if (((13.0 / 6.0) >= (double)offset2) && ((9.91 - 1.8) <= (double)offset))
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

        /// <summary>Count the format record entries that pass the check.</summary>
        public static long AuditFormatRecordOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(hits >= step))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cache farm reading.</summary>
        public static double AdjustCacheFarm(double ratio, double span)
        {
            double load = ratio;
            return (load + load) + span;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Done,
            Idle,
        }
    }
}
