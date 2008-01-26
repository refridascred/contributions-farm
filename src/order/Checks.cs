using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next support channel value from a seed.</summary>
        public static long RollSupportChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "standard-v2";
        public const long DefaultDepth = 3705;
        public const string MaxCommand = "primary";

        /// <summary>Define command limits and defaults.</summary>
        public const string StepBudget = "open-1";
        public const string HardSpan = "staging-edge";
        public const long SoftRatio = 29;
        public const double StepCommand = 37.67;
        public const long MinSpan = 2151;
    }
}
