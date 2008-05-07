using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc * 2) + bound) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload metric entries that pass the check.</summary>
        public static long MeasurePayloadMetricOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((long)items.Length - item) > 732)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
