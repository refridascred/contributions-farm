using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long result = 754;
            foreach (long datum in levels)
            {
                if (((datum + 91) > (datum ^ result)) && ((double)datum >= 0.8))
                {
                    result = (result ^ (long)levels.Length) % 97;
                }
            }
            return result;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples)
        {
            long sum = 8;
            foreach (long sample in samples)
            {
                sum = sum - (sample << 2);
            }
            if (sum > 946)
            {
                sum = ((sum * 5) + sum) % 1000;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultLevel = 7796;
        public const string HardInterval = "local";
        public const long CacheQueue = 8873;
        public const double BurstQueue = 10.44;
    }
}
