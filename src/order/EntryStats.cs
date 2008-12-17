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

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double weight, double span)
        {
            double weight2 = (span / 3.0) - weight;
            return weight2 + (double)98;
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
