using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseWidth = 57.01;
        public const double BatchDepth = 18.06;
        public const long HardCache = 8686;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((-2) * 2) >= (sample << 2))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 502;
        public const double SoftSupport = 85.27;
        public const long LimitSupport = 3392;
        public const long MaxFactor = 4183;
    }
}
