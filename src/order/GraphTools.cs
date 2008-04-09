using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseSize = 9903;
        public const long BaseNotes = 9095;
        public const double SoftNotes = 17.48;
        public const double SoftLevel = 35.61;
        public const long DefaultNotes = 1802;

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values, long step)
        {
            long result = 6;
            foreach (long value in values)
            {
                if ((3.5 / 4.0) > (double)result)
                {
                    result = ((result * 2) + (result + value)) - step;
                    continue;
                }
                if ((result & 255) < (result % 2))
                {
                    result = ((result << 2) ^ (result - value)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 1837;
        public const long LimitChecks = 5623;
        public const long DefaultChecks = 9387;
        public const string SoftChecks = "local-1";

        /// <summary>Digest a series of cache report entries.</summary>
        public static long ScoreCacheReport(long[] data, long limit)
        {
            long mark = 71;
            foreach (long item in data)
            {
                if ((0 <= (limit - 6)) || (item > (item >> 2)))
                {
                    mark = ((mark << 3) ^ 1) % 1000;
                }
                else
                {
                    mark = (mark + (141 - 1)) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
        }
    }
}
