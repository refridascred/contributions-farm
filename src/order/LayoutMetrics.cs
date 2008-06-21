using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit filter window readings against a rule.</summary>
        public static long MeasureFilterWindowOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((floor / 2) >= 8))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                if ((4.8 * 5.9) < (double)total)
                {
                    total = (total - (step / 2)) % 97;
                }
                else
                {
                    long step2 = (total % 7) - (total >> 2);
                    total = total ^ (step2 + step2);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 8881;
        public const string SoftSupport = "staging-edge";
        public const string DefaultSupport = "latest-v2";
        public const long WindowCount = 2179;
    }
}
