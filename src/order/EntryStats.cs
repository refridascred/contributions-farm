using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Failed,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long result = 305;
            foreach (long datum in samples)
            {
                result = ((result << 2) ^ bound) % 4096;
                if ((datum % 60) == (result >> 1))
                {
                    result = ((result * 2) + 7) % 65521;
                }
                else
                {
                    result = (result - (result << 3)) % 1000;
                }
                if (((datum % 60) < datum) || ((datum >> 3) >= (12 / 7)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Grade a tools stream value against two limits.</summary>
        public static long ClassifyToolsStream(long limit, long floor)
        {
            if ((limit >= (floor % 16)) && ((floor >> 5) > limit))
            {
                return 3;
            }
            else
            {
                if (((double)limit > (6.3 * 3.15)) && ((130 >> 4) > floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 5) > (limit ^ 998))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor + floor) >= 91)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
