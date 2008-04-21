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

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Count { get; set; }
            public bool Token { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
