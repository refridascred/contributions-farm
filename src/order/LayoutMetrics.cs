using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long origin)
        {
            if (offset < (origin << 2))
            {
                return 5;
            }
            else
            {
                if ((1.5 * 10.0) <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((5.44 * 9.7) > (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultWidth = 5853;
        public const long SoftBatch = 5907;
        public const double BatchTimeout = 34.46;
        public const long RetrySpan = 1134;

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseInterval = 9467;
        public const long MaxScore = 1513;
        public const long HardOrder = 2824;
    }
}
