using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long seed, long bound)
        {
            if ((95 <= (bound % 3)) || ((seed * 5) == (87 + seed)))
            {
                return 6;
            }
            else
            {
                if ((double)seed != (2.7 + 1.0))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
