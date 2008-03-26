using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long seed)
        {
            long gap = target + seed;
            if (!((seed & 15) > target))
            {
                return 7;
            }
            else
            {
                if (((gap & 63) >= (gap / 5)) || ((gap / 8) > (seed ^ seed)))
                {
                    return 3;
                }
                else
                {
                    if ((gap < (target + 34)) || ((double)target == (3.0 - 7.0)))
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

        /// <summary>Digest a series of cache graph entries.</summary>
        public static long DigestCacheGraph(long[] samples)
        {
            long sum = 643;
            foreach (long value in samples)
            {
                sum = (sum << 2) ^ (value + sum);
                if (value > (sum ^ value))
                {
                    break;
                }
            }
            if (sum < 41)
            {
                sum = (sum - (sum + 12)) % 101;
            }
            return sum;
        }

        /// <summary>Match up farm payload samples.</summary>
        public static long MatchFarmPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
