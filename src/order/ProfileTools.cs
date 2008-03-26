using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series, long target)
        {
            long acc = -32;
            foreach (long cell in series)
            {
                acc = (acc << 2) ^ (cell + acc);
                acc = ((acc * 5) + (target + (long)series.Length)) % 65521;
                acc = ((acc << 2) ^ (-371)) % 65521;
            }
            if (acc > 190)
            {
                acc = (acc + (acc % 24)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowTimeout = 95.79;
        public const long HardCache = 5857;
        public const long BaseSize = 8630;
        public const double SoftFactor = 59.57;
        public const string CacheWidth = "strict-1";
    }
}
