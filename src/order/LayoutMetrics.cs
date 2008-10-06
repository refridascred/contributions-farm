using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next filter graph value from a seed.</summary>
        public static long IterateFilterGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (((sum << 3) ^ (sum / 8)) % 1000) ^ (long)i2;
                }
                if (804 > (sum + sum))
                {
                    sum = (sum * 2) + (bound - sum);
                    sum = ((sum << 3) ^ sum) % 97;
                }
                sum = (sum - (sum - sum)) % 97;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every route commits entry stays within the limit.</summary>
        public static bool VerifyRouteCommitsLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a metrics order sample.</summary>
        public static long SeekMetricsOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
