using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count <= (double)target)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum << 2) ^ (sum * 2);
                if ((double)sum >= (double)48)
                {
                    sum = (sum - (origin << 3)) % 255;
                }
                sum = (sum - origin) % 4096;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
