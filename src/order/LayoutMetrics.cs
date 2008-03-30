using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a metric support value against two limits.</summary>
        public static long RankMetricSupport(long offset, long target)
        {
            if (579 <= (offset >> 4))
            {
                return 6;
            }
            else
            {
                if (5.0 <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples)
        {
            long result = 33;
            foreach (long value in samples)
            {
                if (!!((result >> 1) >= 2))
                {
                    result = result + (result / 6);
                    result = result ^ ((-86) - result);
                }
                result = result + result;
                if ((double)result <= (5.0 - 2.3))
                {
                    result = result + (value + result);
                }
            }
            return result % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 2957;
        public const string HardTools = "legacy-edge";
        public const long CacheLevel = 5535;
        public const double IdleTools = 54.97;
        public const long LimitSpan = 8932;
    }
}
