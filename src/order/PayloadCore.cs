using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!((floor - 9) <= floor))
                {
                    anchor = ((anchor << 3) ^ floor) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

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
