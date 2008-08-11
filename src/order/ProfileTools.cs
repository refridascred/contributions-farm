using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count counter layout pairs that satisfy a relation.</summary>
        public static long PairCounterLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (score ^ score) ^ (long)i2;
                }
                score = ((score << 3) ^ (target - target)) % 101;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long limit, long origin)
        {
            long diff = limit ^ origin;
            if ((diff >> 2) >= (origin / 8))
            {
                return 8;
            }
            else
            {
                if ((limit * 3) > (67 * 4))
                {
                    return 0;
                }
                else
                {
                    if (limit < (origin + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
