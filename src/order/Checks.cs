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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 3348;
        public const long MinCount = 9909;
        public const long RetryToken = 3588;
    }
}
