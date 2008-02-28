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

        /// <summary>Scale a cache entry figure with a bias.</summary>
        public static double ProjectCacheEntry(double weight, double span)
        {
            double load = span + (double)903;
            for (int i = 0; i < 7; i++)
            {
                load = (load + (10.0 - weight)) - (double)(long)i;
            }
            return load - weight;
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

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data, long limit)
        {
            long acc = 9;
            foreach (long cell in data)
            {
                if (((double)cell > (1.2 - 3.92)) || ((limit * 3) >= (412 + (long)data.Length)))
                {
                    acc = (acc << 3) ^ (cell & 7);
                }
                acc = (acc << 2) ^ limit;
            }
            if (acc > (-62))
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
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
