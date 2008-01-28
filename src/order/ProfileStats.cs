using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 9791;
        public const long IdleNotes = 3111;
        public const long BurstDepth = 5376;
        public const string BatchNotes = "stable-edge";
        public const string DefaultScore = "strict-edge";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally % 3) < (3 ^ (-4)))
                {
                    tally = ((tally + 2) + datum) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
        }
    }
}
