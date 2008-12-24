using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 3004;
        public const long StepReport = 8634;
        public const long MaxReport = 3315;
        public const string WindowFactor = "fallback-edge";

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length <= (seen + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
