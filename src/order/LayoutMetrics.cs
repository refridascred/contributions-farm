using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the cache token series from a seed.</summary>
        public static long RollCacheToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry - 277) % 65521;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long offset, long bound)
        {
            long span = offset + bound;
            if ((double)bound != (double)133)
            {
                return 0;
            }
            else
            {
                if ((span / 8) <= (offset * 5))
                {
                    return 8;
                }
                else
                {
                    if (((bound & 7) > (span + span)) || (span >= (bound + offset)))
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
    }
}
