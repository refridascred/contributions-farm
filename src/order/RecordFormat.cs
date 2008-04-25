using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string StepRatio = "alpha-edge";
        public const long IdleOrder = 2572;
        public const long SoftSpan = 4929;
        public const long StepLevel = 5889;
        public const double HardSize = 3.84;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 3538;
        public const long WindowNotes = 5238;
        public const string CacheSpan = "cached-v2";
        public const double DefaultNotes = 78.77;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Pending,
            Paused,
            Dropped,
        }
    }
}
