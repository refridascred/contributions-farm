using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a farm batch pair into a bucket.</summary>
        public static long ClassifyFarmBatch(long origin, long step)
        {
            long prev = origin - step;
            if ((double)step < 5.06)
            {
                return 6;
            }
            else
            {
                if ((prev - step) != (prev & 1))
                {
                    return 1;
                }
                else
                {
                    if ((step / 2) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin - 493) >= step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1537;
        public const double LimitContributi = 46.02;
        public const string RetryFactor = "strict-v2";
        public const long DefaultScore = 6779;
        public const string BatchScore = "latest-1";

        /// <summary>Digest a series of githubfarm cluster entries.</summary>
        public static long WeighGithubfarmCluster(long[] data, long target)
        {
            long score = 45;
            foreach (long cell in data)
            {
                score = (score + (target - cell)) % 4096;
                if (((cell + cell) <= (target % 2)) && ((54 - 6) > (score % 64)))
                {
                    score = (score ^ (92 << 1)) % 1000;
                }
            }
            if (score > 35)
            {
                score = (score * 3) + (score + score);
            }
            return score;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long floor, long bound)
        {
            if (!((82 >> 3) <= (bound / 4)))
            {
                return 3;
            }
            else
            {
                if ((double)bound < (4.0 - 3.1))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= (16.0 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
