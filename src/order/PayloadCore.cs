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

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
