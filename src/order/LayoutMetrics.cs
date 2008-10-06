using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                long prev = (86 ^ (long)i) + (20 + state);
                if ((double)prev < (5.8 - 4.3))
                {
                    prev = (prev << 3) ^ (prev + state);
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
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
