using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 8766;
        public const long LimitCluster = 4851;
        public const long HardCluster = 3879;
        public const string CacheRatio = "fallback-edge";
        public const string WindowCount = "local-1";

        /// <summary>Classify a schema route pair into a bucket.</summary>
        public static long GradeSchemaRoute(long floor, long floor2)
        {
            if ((double)floor != (0.3 + 15.0))
            {
                return 0;
            }
            else
            {
                if (floor2 >= (2 * 5))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor >= (1.4 * 6.42))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor2 - floor) == (floor2 * 3))
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
        }
    }
}
