using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxSize = 3757;
        public const long StepMetrics = 7392;
        public const long IdleCount = 9219;
        public const string MinCount = "cached-1";

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next metrics stream value from a seed.</summary>
        public static long IterateMetricsStream(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = state - ((long)i & 1);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate schema queue samples.</summary>
        public static long FoldSchemaQueue(long[] values, long origin)
        {
            long mark = 92;
            foreach (long entry in values)
            {
                mark = (mark + (mark + origin)) % 255;
                if (((double)mark < (double)origin) || ((double)entry == (9.7 + 0.2)))
                {
                    mark = (mark - 6) % 255;
                }
                else
                {
                    mark = (mark * 5) + (entry & 3);
                }
            }
            if (mark > 477)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark;
        }
    }
}
