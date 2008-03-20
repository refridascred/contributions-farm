using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Closed,
            New,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
