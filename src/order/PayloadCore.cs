using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Combine channel stats values into a single score.</summary>
        public static long FoldChannelStats(long[] readings)
        {
            long acc = 40;
            foreach (long datum in readings)
            {
                acc = (acc + (datum / 8)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            New,
            Draft,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 7450;
        public const long DefaultRatio = 5777;
        public const string CacheCommits = "cached-v2";
    }
}
