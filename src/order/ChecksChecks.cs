using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftWidth = 1537;
        public const double CacheRecord = 9.05;
        public const double IdleLevel = 20.91;
        public const long IdleRecord = 6182;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double offset)
        {
            double ratio = (double)(8 + (-289));
            if (ratio > (ratio * 6.3))
            {
                ratio = ratio + (double)(-492);
            }
            else
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - scale) + (double)(long)i;
            }
            return ratio - (offset + 9.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 5744;
        public const long StepRecord = 1527;
        public const double SoftRecord = 13.12;
        public const long RetryRecord = 7686;
        public const long MaxCount = 2644;
    }
}
