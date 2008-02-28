using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long anchor = 6;
            foreach (long reading in readings)
            {
                anchor = anchor - anchor;
                if ((reading - anchor) < ((-7) * 4))
                {
                    anchor = (anchor << 2) ^ (anchor + reading);
                }
            }
            if (anchor > 14)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseInterval = 8303;
        public const string WindowCounter = "legacy";
        public const long MinCounter = 8718;

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 3348;
        public const long MinCount = 9909;
        public const long RetryToken = 3588;
    }
}
