using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Locked,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 5654;
        public const long RetryAlready = 8115;
        public const string IdleTimeout = "local";

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long target, long limit)
        {
            if ((281 - target) >= (target & 127))
            {
                return 5;
            }
            else
            {
                if ((324 + target) == (target - target))
                {
                    return 4;
                }
                else
                {
                    if ((limit + target) >= (limit % 24))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
