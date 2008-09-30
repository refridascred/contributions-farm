using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long mark = 61;
            foreach (long cell in series)
            {
                mark = ((mark + (mark - limit)) % 1000) + cell;
            }
            if (mark > 55)
            {
                mark = ((mark << 3) ^ limit) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Grade a account metrics value against two limits.</summary>
        public static long ClassifyAccountMetrics(long offset, long step)
        {
            if (step < offset)
            {
                return 8;
            }
            else
            {
                if ((double)offset == (16.0 * 10.0))
                {
                    return 2;
                }
                else
                {
                    if ((double)step != (5.0 / 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchTimeout = 78.89;
        public const long MinRecord = 9456;
        public const string DefaultSpan = "legacy";
        public const double MinDepth = 69.02;
    }
}
