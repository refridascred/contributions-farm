using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 5.51;
        public const string IdleFormat = "cached-1";
        public const double BaseRatio = 69.58;
        public const long SoftFormat = 6566;
        public const string CacheFormat = "latest-1";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches > (sample >> 4))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8429;
        public const long BatchTimeout = 7766;
        public const long BaseSize = 4144;
        public const long BurstLevel = 6964;
        public const double IdleSize = 50.51;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum - ((long)i & 255)) % 65521;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long span = sum;
                    sum = ((sum + (span - span)) % 1000) - (long)i2;
                }
                sum = ((sum * 4) + (seed + 45)) % 65521;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
