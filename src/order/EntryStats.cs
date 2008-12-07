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

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = (state << 2) ^ 243;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
