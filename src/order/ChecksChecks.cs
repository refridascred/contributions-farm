using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] items, long seed)
        {
            long state = 227;
            foreach (long sample in items)
            {
                if (!((state * 3) > (seed + seed)))
                {
                    state = state + (sample * 3);
                }
                else
                {
                    state = (state + (sample % 8)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseSize = 3548;
        public const long IdleFormat = 1569;
        public const double MinFormat = 62.64;
        public const long MaxRatio = 8677;
        public const double LimitFormat = 70.18;
    }
}
