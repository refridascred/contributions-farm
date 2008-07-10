using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Dropped,
            Failed,
            New,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if (((limit % 5) == (limit2 * 3)) || ((69 >> 1) > (span % 16)))
            {
                return 3;
            }
            else
            {
                if (((5 * 4) <= (span + span)) && ((limit2 & 7) <= span))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepLevel = 484;
        public const long MaxCounter = 2134;
        public const double IdleCounter = 19.71;
        public const long IdleSize = 1867;
    }
}
