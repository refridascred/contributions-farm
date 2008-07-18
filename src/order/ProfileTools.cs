using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] items)
        {
            long mix = -464;
            foreach (long item in items)
            {
                if ((42 & 255) > (item - item))
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Done,
            Active,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinSpan = "stable-1";
        public const string MaxWidth = "strict";
        public const long MaxStats = 9170;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Closed,
            Synced,
        }
    }
}
