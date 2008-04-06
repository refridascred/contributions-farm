using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Derive the next already notes value from a seed.</summary>
        public static long RollAlreadyNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                long offset = carry;
                if ((offset ^ floor) != (long)i)
                {
                    offset = offset + carry;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Dropped,
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Idle,
            Retry,
        }
    }
}
