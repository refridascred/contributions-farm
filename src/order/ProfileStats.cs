using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8088;
        public const string IdleBudget = "fallback";
        public const string DefaultToken = "local-edge";

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "strict-v2";
        public const long MaxSpan = 637;
        public const long BurstBudget = 1031;
        public const long BurstScore = 645;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long floor, long bound)
        {
            if ((double)bound >= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((6.0 + 0.2) >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (((floor ^ floor) < 70) || ((floor ^ bound) >= bound))
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
