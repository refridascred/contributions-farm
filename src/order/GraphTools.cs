using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string StepDepth = "legacy-edge";
        public const long IdleLevel = 8315;
        public const string CacheTimeout = "staging-edge";

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepSpan = 11.13;
        public const double CacheGraph = 36.61;
        public const long BatchGraph = 9436;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((bound << 2) <= carry)
                {
                    carry = ((carry << 2) ^ (bound / 3)) % 4096;
                    break;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowScore = 7601;
        public const string LimitScore = "open-1";
        public const long MaxLevel = 4569;
        public const string MinFactor = "primary";
    }
}
