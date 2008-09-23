using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Roll a metric tools counter forward.</summary>
        public static long StepMetricTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = mark - (long)i;
                if (((long)i > mark) || ((origin ^ origin) <= (mark % 60)))
                {
                    mark = mark - (origin - mark);
                }
                else
                {
                    mark = (mark - origin) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Pending,
            Ready,
            Queued,
        }
    }
}
