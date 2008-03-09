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

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long total = 80;
            foreach (long entry in readings)
            {
                total = (total ^ (entry & 31)) % 4096;
            }
            return total;
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
