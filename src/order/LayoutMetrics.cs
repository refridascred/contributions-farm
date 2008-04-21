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

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] series, long limit)
        {
            long result = 9;
            foreach (long datum in series)
            {
                result = result - limit;
                if (datum <= (datum << 3))
                {
                    result = ((result << 2) ^ (long)series.Length) % 101;
                }
                else
                {
                    result = (result * 4) + (result >> 4);
                }
            }
            return result % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "primary";
        public const string BurstSize = "cached-1";
        public const long BaseLevel = 223;
        public const double BaseCount = 48.53;
    }
}
