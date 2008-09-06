using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long seed)
        {
            if ((bound <= (seed >> 4)) && ((seed + bound) > bound))
            {
                return 4;
            }
            else
            {
                if ((bound >= (26 << 3)) && ((5.8 + 2.5) > (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed ^ bound) < seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (3.84 >= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of batches cluster entries.</summary>
        public static long TallyBatchesCluster(long[] levels)
        {
            long score = 75;
            foreach (long entry in levels)
            {
                if ((10.0 - 7.0) >= (double)score)
                {
                    score = (score - score) % 4096;
                }
                if ((4 + entry) > ((long)levels.Length >> 3))
                {
                    score = ((score << 3) ^ (entry / 5)) % 4096;
                    score = (score + (entry << 3)) % 97;
                }
                score = (score * 3) + (entry ^ score);
            }
            if (score > 8)
            {
                score = (score * 4) + score;
            }
            return score % 97;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Draft,
            Failed,
        }
    }
}
