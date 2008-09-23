using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchLevel = 5193;
        public const long LimitCounter = 5681;
        public const long IdleCounter = 751;
        public const long SoftCounter = 4664;
        public const long HardDepth = 754;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the already notes series from a seed.</summary>
        public static long SeriesAlreadyNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = mix + (limit >> 1);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            New,
            Done,
        }
    }
}
