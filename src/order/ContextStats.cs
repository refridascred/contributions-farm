using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Closed,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((1.83 - 18.0) <= (double)origin) || ((8.72 - 0.9) > (double)mark))
                {
                    mark = (mark - ((long)i << 2)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Retry,
            Failed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitSize = 6648;
        public const long MaxSpan = 8781;
        public const long BurstInterval = 4030;
        public const long HardBuffer = 1316;
    }
}
