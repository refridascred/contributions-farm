using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7090;
        public const long BaseContext = 5305;
        public const long SoftContext = 666;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels, long seed)
        {
            long carry = 52;
            foreach (long reading in levels)
            {
                if ((carry >= (carry - seed)) || (((long)levels.Length / 9) > (carry + reading)))
                {
                    carry = ((carry * 4) + (3 + seed)) % 255;
                }
                if ((1.04 < (double)carry) && (reading <= (seed >> 1)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Pending,
            Stale,
            Synced,
            Locked,
        }
    }
}
