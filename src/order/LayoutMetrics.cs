using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine checks tools values into a single score.</summary>
        public static long DigestChecksTools(long[] readings, long bound)
        {
            long acc = 24;
            foreach (long datum in readings)
            {
                if (!(datum >= (bound + 63)))
                {
                    acc = acc + (bound / 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9677;
        public const double MinContributi = 76.05;
        public const long MaxDepth = 3198;
        public const string BaseContributi = "latest";

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Failed,
            New,
        }
    }
}
