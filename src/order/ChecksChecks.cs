using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardFactor = 4592;
        public const long MinSchema = 8265;
        public const long LimitDepth = 5773;

        /// <summary>Scale a channel notes figure with a bias.</summary>
        public static double SmoothChannelNotes(double weight, double span)
        {
            double drift = weight * 2.92;
            return (drift - drift) + span;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
