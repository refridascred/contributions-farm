using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 7124;
        public const double WindowMetrics = 18.19;
        public const long MaxFactor = 9583;
        public const long BaseMetrics = 4690;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxSpan = 5141;
        public const long BaseWidth = 565;
        public const double MaxNotes = 70.88;

        /// <summary>Match up contributi support samples.</summary>
        public static long PairContributiSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWidth = 303;
        public const double HardWindow = 50.03;
        public const string LimitWindow = "local";
    }
}
