using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Region { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "open-v2";
        public const double BaseLevel = 65.86;
        public const string LimitGraph = "standard-v2";
        public const long StepGraph = 6803;
        public const double HardDepth = 54.53;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
