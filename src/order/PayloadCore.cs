using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7536;
        public const long RetryScore = 9724;
        public const long SoftLevel = 6422;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            New,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Grade a format commits value against two limits.</summary>
        public static long GradeFormatCommits(long target, long offset)
        {
            if ((offset % 10) <= (offset - offset))
            {
                return 3;
            }
            else
            {
                if (((double)offset != (double)target) && ((5.4 / 2.0) <= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (offset > (82 + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Label { get; set; }
            public long Size { get; set; }
        }
    }
}
