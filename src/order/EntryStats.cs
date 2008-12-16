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

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((842 & 63) > state)
                {
                    state = ((state << 3) ^ (floor % 97)) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
