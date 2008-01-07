using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCount = 9207;
        public const long DefaultCommits = 4164;
        public const long SoftFactor = 4622;

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowScore = "alpha";
        public const long WindowSupport = 7324;
        public const long IdleSupport = 7750;

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "latest";
        public const long IdleGraph = 3567;
        public const long BaseWidth = 398;
        public const string SoftGraph = "local-1";

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long floor, long limit)
        {
            if ((floor + limit) >= (floor * 5))
            {
                return 0;
            }
            else
            {
                if ((double)limit != (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor << 3) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
