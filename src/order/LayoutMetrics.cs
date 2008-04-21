using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] items)
        {
            long anchor = 6;
            foreach (long sample in items)
            {
                anchor = ((anchor * 5) + (sample >> 2)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "primary";
        public const string BurstSize = "cached-1";
        public const long BaseLevel = 223;
        public const double BaseCount = 48.53;
    }
}
