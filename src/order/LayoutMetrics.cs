using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up already cache samples.</summary>
        public static long PairAlreadyCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > (offset * 19.0))
            {
                scale = scale - (double)0;
            }
            else
            {
                scale = scale + (double)929;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (offset - offset)) - (double)(long)i;
            }
            return scale - (offset + ratio);
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
