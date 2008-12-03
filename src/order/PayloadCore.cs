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

        /// <summary>Measure how many already metrics samples are out of range.</summary>
        public static long TallyAlreadyMetricsMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample > (tally + sample)) || (sample < (sample & 127)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }
    }
}
