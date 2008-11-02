using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "cached-1";
        public const long IdleToken = 8085;
        public const long BatchToken = 2512;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long seed, long limit)
        {
            if (((2.0 + 4.0) > (double)seed) || ((limit + seed) >= (seed & 127)))
            {
                return 7;
            }
            else
            {
                if ((double)limit != (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((41 ^ limit) == (930 - 42))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit + seed) > (limit >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks commits readings against a rule.</summary>
        public static long TallyChecksCommitsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) > (matches * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
