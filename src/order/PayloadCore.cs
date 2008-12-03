using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepTimeout = 63.49;
        public const double StepInterval = 72.59;
        public const long SoftCommits = 8555;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches >> 5) >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
