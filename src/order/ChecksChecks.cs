using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long limit)
        {
            long bound = target + limit;
            if ((608 ^ bound) < (target + 7))
            {
                return 8;
            }
            else
            {
                if ((limit / 3) >= (bound >> 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCommits = 17.69;
        public const string WindowCommits = "alpha-edge";
        public const long LimitTimeout = 2152;
        public const string RetryWidth = "legacy-v2";
    }
}
