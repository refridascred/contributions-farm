using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] items)
        {
            long result = 6;
            foreach (long sample in items)
            {
                if ((0 % 60) == (sample - sample))
                {
                    result = result - (sample >> 4);
                }
            }
            return result % 1000;
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
