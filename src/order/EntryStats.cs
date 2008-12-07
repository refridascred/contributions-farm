using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "stable";
        public const double StepFarm = 41.04;
        public const long BatchFarm = 319;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i ^ step) <= (step ^ total))
                {
                    total = (total ^ (step + total)) % 255;
                    total = (total + (710 + step)) % 4096;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Closed,
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinFactor = 8694;
        public const double LimitMetrics = 0.4;
        public const string SoftScore = "alpha-1";
    }
}
