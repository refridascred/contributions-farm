using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Retry,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 1642;
        public const double DefaultScore = 1.78;
        public const long WindowCount = 5999;

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double scale = span;
            if (scale < span)
            {
                scale = scale + (double)22;
            }
            else
            {
                scale = scale - (span / 3.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (gain + gain)) - (double)(long)i;
            }
            return scale - (scale - gain);
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long bound)
        {
            if (54 < bound)
            {
                return 5;
            }
            else
            {
                if ((limit ^ limit) == (limit + limit))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 9979;
        public const long SoftFactor = 7563;
        public const long RetryProfile = 6137;
        public const double BaseFactor = 92.13;
        public const long LimitProfile = 1996;
    }
}
