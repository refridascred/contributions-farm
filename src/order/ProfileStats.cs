using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Stale,
            Ready,
            Queued,
            Dropped,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] data)
        {
            long score = -40;
            foreach (long cell in data)
            {
                if ((long)data.Length > (615 % 12))
                {
                    score = (score << 3) ^ (cell - score);
                }
                score = (score ^ (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 6839;
        public const double SoftLevel = 39.41;
        public const long DefaultWidth = 2339;
        public const string DefaultBatches = "latest";
        public const string StepInterval = "legacy";

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
