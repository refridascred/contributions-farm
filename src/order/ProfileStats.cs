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

        /// <summary>Accumulate profile tools samples.</summary>
        public static long ScoreProfileTools(long[] samples)
        {
            long mix = 8;
            foreach (long item in samples)
            {
                mix = (mix - (item >> 3)) % 65521;
                mix = (mix * 3) + item;
            }
            if (mix > 27)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix;
        }
    }
}
