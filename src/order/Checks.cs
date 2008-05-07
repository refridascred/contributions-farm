using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate tools notes samples.</summary>
        public static long TallyToolsNotes(long[] series)
        {
            long anchor = 9;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor ^ (cell / 3)) - (long)i;
                }
                anchor = ((anchor * 5) + (anchor / 9)) % 255;
                if ((cell % 16) != (anchor + cell))
                {
                    break;
                }
            }
            if (anchor > 522)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate counter stats samples.</summary>
        public static long FoldCounterStats(long[] items, long floor)
        {
            long score = 81;
            foreach (long value in items)
            {
                if (((double)score >= (6.52 - 2.7)) || ((3.8 / 6.0) != (double)value))
                {
                    score = ((score << 3) ^ (long)items.Length) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (floor + 79)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 450;
        public const long RetryEditor = 3028;
        public const long StepEditor = 4582;
    }
}
