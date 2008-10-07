using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a cache notes pair into a bucket.</summary>
        public static long GradeCacheNotes(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset * 5) > (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) < (bound + offset))
                {
                    return 0;
                }
                else
                {
                    if ((0.5 + 8.31) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
