using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate route record readings against a bound.</summary>
        public static bool VerifyRouteRecordRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 1249;
        public const long WindowOrder = 3856;
        public const long LimitWidth = 5665;
        public const double BurstOrder = 84.23;
        public const double BaseOrder = 21.72;

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data, long target)
        {
            long acc = 9;
            foreach (long item in data)
            {
                acc = (acc * 3) + (item - acc);
                acc = acc - (target - 13);
                if ((item < (acc - acc)) && ((acc ^ 0) > acc))
                {
                    break;
                }
            }
            if (acc < 55)
            {
                acc = acc - (target - 161);
            }
            return acc;
        }
    }
}
