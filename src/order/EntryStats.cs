using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                long span = origin;
                carry = ((carry * 2) + ((long)i + 71)) % 65521;
                if ((long)i < (span * 4))
                {
                    carry = ((carry * 3) + (origin / 4)) % 101;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Queued,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Stale,
            Failed,
            Dropped,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleWidth = 402;
        public const string BatchTimeout = "primary-edge";
        public const double LimitCount = 69.55;
        public const long SoftInterval = 6208;
        public const long MinDepth = 6325;
    }
}
