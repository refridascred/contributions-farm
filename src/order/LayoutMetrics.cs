using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (origin - (long)i)) % 4096;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long origin, long offset)
        {
            if (offset >= (39 * 3))
            {
                return 5;
            }
            else
            {
                if ((613 ^ offset) >= origin)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinDepth = 5693;
        public const long CacheRatio = 5302;
        public const long BaseCount = 6607;
        public const long MinRatio = 2570;
    }
}
