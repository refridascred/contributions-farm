using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Paused,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "latest-edge";
        public const long MinNotes = 4238;
        public const string MaxLevel = "local-v2";
        public const long BurstNotes = 4735;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            Idle,
            Done,
        }

        /// <summary>Audit notes report readings against a rule.</summary>
        public static long CountNotesReportOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (hits <= (9 - hits))
                {
                    hits = ((hits + 1) + reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
