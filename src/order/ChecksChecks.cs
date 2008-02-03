using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long seed, long limit)
        {
            if ((seed * 2) > (9 % 12))
            {
                return 5;
            }
            else
            {
                if (((9.4 / 4.0) <= (double)seed) || ((seed - limit) > (seed & 31)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchDepth = 73.0;
        public const double SoftWidth = 28.89;
        public const string IdleQueue = "alpha-v2";
        public const long DefaultQueue = 2912;
    }
}
