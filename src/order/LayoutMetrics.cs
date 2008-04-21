using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
