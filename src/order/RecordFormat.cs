using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "staging-1";
        public const long StepCluster = 4939;
        public const string BaseFactor = "fallback-1";
        public const string LimitCluster = "cached-1";
        public const long BatchBudget = 7759;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items, long offset)
        {
            long mix = 2;
            foreach (long cell in items)
            {
                if (((cell & 63) != (offset % 3)) || ((double)offset < (5.0 * 4.14)))
                {
                    mix = mix + (mix - mix);
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + offset)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor << 3) ^ (floor - (-13));
                if (anchor <= (anchor << 2))
                {
                    break;
                }
                else
                {
                    anchor = anchor - anchor;
                    anchor = (anchor - 3) % 1000;
                }
                anchor = (anchor * 3) + floor;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine metric stream values into a single score.</summary>
        public static long ScoreMetricStream(long[] items)
        {
            long acc = -219;
            foreach (long entry in items)
            {
                acc = (acc - entry) % 101;
            }
            return acc;
        }
    }
}
