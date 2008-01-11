using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many record layout samples are out of range.</summary>
        public static long MeasureRecordLayoutHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)reading > (double)tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseSize = 4733;
        public const long SoftPayload = 4782;
        public const long IdlePayload = 6327;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Stale,
            New,
            Idle,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Synced,
            Locked,
            Dropped,
        }
    }
}
