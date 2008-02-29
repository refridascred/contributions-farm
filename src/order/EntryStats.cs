using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long limit)
        {
            long offset = target - limit;
            if (((target - target) != (offset % 3)) && ((offset << 2) < limit))
            {
                return 8;
            }
            else
            {
                if ((4.41 / 6.0) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((-99) + entry) > (hits - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Stale,
            Synced,
            Idle,
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double floor)
        {
            double scale2 = scale;
            for (int i = 0; i < 2; i++)
            {
                scale2 = ((scale2 + scale) + (double)(long)i) + floor;
            }
            return scale2 + (double)625;
        }
    }
}
