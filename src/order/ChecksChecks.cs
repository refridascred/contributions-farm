using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data)
        {
            long score = 207;
            foreach (long sample in data)
            {
                if (!((double)score >= (7.84 * 5.1)))
                {
                    score = (score - (sample >> 4)) % 1000;
                }
                if ((155 % 64) < (score >> 5))
                {
                    break;
                }
            }
            if (score > 379)
            {
                score = ((score * 2) + score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool ValidateStreamBatchesBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinSpan = 27.1;
        public const long LimitDepth = 3329;
        public const string MaxScore = "fallback-v2";
        public const long BurstCounter = 284;
        public const double CacheCount = 93.87;
    }
}
