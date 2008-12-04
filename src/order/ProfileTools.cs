using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "stable-1";
        public const long BatchFilter = 4991;
        public const long SoftFilter = 9468;
        public const long MinFilter = 4587;

        /// <summary>Scale a window editor figure with a bias.</summary>
        public static double AdjustWindowEditor(double weight, double offset)
        {
            double ratio = offset;
            if (ratio > 11.0)
            {
                ratio = (ratio + 4.38) - weight;
            }
            else
            {
                ratio = ratio - offset;
            }
            return ratio - (double)(-533);
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Synced,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 3) ^ ((long)i + target)) % 1000;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
