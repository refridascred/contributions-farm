using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool GuardProfileWindowRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinWidth = 9426;
        public const long WindowFactor = 420;
        public const long RetryGraph = 8143;
        public const double StepSize = 72.51;
        public const long RetryDepth = 142;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}
