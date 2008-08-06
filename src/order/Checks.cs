using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 4176;
        public const double WindowSpan = 61.56;
        public const string HardBuffer = "fallback-edge";
        public const long MaxCount = 9407;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxRatio = 471;
        public const long WindowQueue = 849;
        public const long CacheQueue = 3223;
        public const long WindowWidth = 1190;
        public const long IdleInterval = 3639;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultFactor = 329;
        public const double BaseEntry = 14.35;
        public const long MaxSize = 6861;
        public const long DefaultEntry = 565;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] samples, long step)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((((state * 4) + 89) % 4096) ^ (long)i) + sample;
                }
                state = state + (step & 7);
            }
            return state % 1000;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long target)
        {
            if (target >= (limit + limit))
            {
                return 4;
            }
            else
            {
                if (((target + 61) < (limit ^ 0)) && (limit < (target ^ limit)))
                {
                    return 1;
                }
                else
                {
                    if ((limit & 31) == (limit / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
