using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Locked,
            Active,
            Idle,
            Done,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((double)limit > (double)mark)
                {
                    mark = mark - (mark + mark);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((3 + offset) < (offset + (long)i))
                {
                    state = ((state << 2) ^ ((long)i % 10)) % 101;
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
