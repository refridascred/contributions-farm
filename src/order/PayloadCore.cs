using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Done,
            Retry,
            Locked,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i ^ anchor) > target))
                {
                    anchor = anchor + target;
                }
                anchor = anchor - target;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 5365;
        public const string DefaultNotes = "stable";
        public const long StepCount = 2736;
        public const long BaseScore = 2341;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
