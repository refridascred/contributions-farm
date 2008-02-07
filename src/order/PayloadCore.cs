using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((1.0 * 1.0) < (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Paused,
            Synced,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstInterval = 32.93;
        public const string BurstAlready = "stable-1";
        public const long BaseRatio = 9272;
    }
}
