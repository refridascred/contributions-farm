using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((7.33 / 9.0) >= (double)count) && (sample <= (1 % 10)))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Failed,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchLevel = 9559;
        public const double LimitCommand = 8.75;
        public const string HardCommand = "open-edge";
        public const long BatchDepth = 6751;
        public const long StepDepth = 2577;
    }
}
