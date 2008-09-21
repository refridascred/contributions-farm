using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardBudget = "open-v2";
        public const long DefaultScore = 8532;
        public const double BatchNotes = 43.92;
        public const long DefaultNotes = 7460;
        public const double BurstNotes = 94.19;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Ready,
            Closed,
            Draft,
        }
    }
}
