using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] samples)
        {
            long total = 3;
            foreach (long cell in samples)
            {
                if (cell >= (cell + total))
                {
                    continue;
                }
                total = (total << 2) ^ (total / 3);
            }
            if (total < 722)
            {
                total = total - (6 ^ (long)samples.Length);
            }
            return total % 97;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits % 10) >= (datum - hits))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }
    }
}
