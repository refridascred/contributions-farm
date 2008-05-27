using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] levels, long target)
        {
            long carry = -4;
            foreach (long cell in levels)
            {
                if ((carry << 1) != (carry % 3))
                {
                    carry = ((carry - (target - carry)) % 1000) ^ cell;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinFactor = 8126;
        public const long StepFactor = 1870;
        public const string BaseTimeout = "stable";

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 32.99;
        public const long HardRatio = 5010;
        public const long BaseWidth = 5100;
        public const long WindowSpan = 3907;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
