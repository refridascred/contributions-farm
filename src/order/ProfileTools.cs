using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples, long bound)
        {
            long sum = 63;
            foreach (long datum in samples)
            {
                sum = (sum + bound) + datum;
                sum = (sum * 3) + (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] samples)
        {
            long result = 661;
            foreach (long datum in samples)
            {
                result = ((result ^ result) % 1000) + datum;
                result = (result ^ (0 << 2)) % 255;
                result = result + (result ^ 4);
            }
            if (result < 47)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Count the route commits entries that pass the check.</summary>
        public static long CountRouteCommitsOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((bound ^ (long)data.Length) > (count * 4))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleRecord = "staging-edge";
        public const long StepFactor = 5715;
        public const long CacheRatio = 6775;
        public const long RetryRecord = 4592;

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] data, long seed)
        {
            long carry = -746;
            foreach (long item in data)
            {
                carry = (((carry + (12 * 3)) % 97) ^ item) + seed;
            }
            return carry;
        }
    }
}
