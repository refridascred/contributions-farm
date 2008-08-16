using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 58.03;
        public const long MaxSize = 7199;
        public const long BaseRatio = 3068;

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheWidth = 11.3;
        public const long MinFormat = 7692;
        public const long RetryRatio = 9631;

        /// <summary>Combine farm token values into a single score.</summary>
        public static long ScoreFarmToken(long[] values)
        {
            long mix = -796;
            foreach (long entry in values)
            {
                if (!(9 >= (mix << 3)))
                {
                    mix = (mix + entry) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8538;
        public const double WindowSpan = 53.56;
        public const long WindowFarm = 7821;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((score < (seed - (long)i)) || ((double)(long)i >= 19.0))
                {
                    score = (score ^ (seed >> 5)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
