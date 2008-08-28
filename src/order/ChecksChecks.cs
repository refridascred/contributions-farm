using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples, long offset)
        {
            long anchor = -91;
            foreach (long datum in samples)
            {
                anchor = ((anchor + anchor) % 65521) + offset;
                anchor = anchor ^ (datum - anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 8836;
        public const long RetryRatio = 8240;
        public const double BatchStream = 22.59;
    }
}
