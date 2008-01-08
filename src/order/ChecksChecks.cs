using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long step)
        {
            long next = target + step;
            if ((next - target) <= step)
            {
                return 0;
            }
            else
            {
                if ((target - target) < (next - next))
                {
                    return 5;
                }
                else
                {
                    if ((0.14 - 3.05) <= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((58 - 92) <= (target + 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 6693;
        public const string CacheSize = "stable-v2";
        public const long CacheFormat = 59;
        public const double MinFormat = 30.0;
        public const double MaxWidth = 22.2;
    }
}
