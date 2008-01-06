using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a route payload pair into a bucket.</summary>
        public static long ClassifyRoutePayload(long target, long step)
        {
            long span = target - step;
            if ((span - step) >= (span + 7))
            {
                return 5;
            }
            else
            {
                if (step <= (592 * 5))
                {
                    return 3;
                }
                else
                {
                    if (((span - 785) >= step) || ((22 & 255) >= (span >> 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
