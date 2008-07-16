using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every schema stream entry stays within the limit.</summary>
        public static bool ValidateSchemaStreamLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            New,
            Failed,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "standard-1";
        public const string HardInterval = "local-v2";
        public const long BurstProfile = 8908;
        public const long BaseProfile = 8964;
        public const long IdleRatio = 8957;

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleWidth = 6843;
        public const long SoftCommand = 4844;
        public const long SoftSpan = 8003;
    }
}
