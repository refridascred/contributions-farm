using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 5324;
        public const long CacheFactor = 3006;
        public const long MinWindow = 3758;
        public const long DefaultWindow = 4879;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long limit2)
        {
            if (!((limit + limit2) < limit))
            {
                return 0;
            }
            else
            {
                if ((limit ^ limit) < (80 & 1))
                {
                    return 1;
                }
                else
                {
                    if (limit2 < (9 * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
