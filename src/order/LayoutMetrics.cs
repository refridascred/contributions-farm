using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitInterval = 1170;
        public const string LimitSize = "strict-1";
        public const string CacheFactor = "alpha-v2";

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark ^ 223) % 65521) ^ (long)i2;
                }
                mark = (mark ^ (long)i) % 65521;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardFactor = "stable-1";
        public const long LimitRecord = 2933;
        public const long HardRecord = 1091;
    }
}
