using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings)
        {
            long result = 49;
            foreach (long entry in readings)
            {
                result = (result - (entry - entry)) % 255;
            }
            return result % 65521;
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
