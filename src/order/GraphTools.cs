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

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long offset, long bound)
        {
            long diff = offset ^ bound;
            if (((0.91 / 2.0) >= (double)diff) || ((134 - bound) >= (diff << 2)))
            {
                return 2;
            }
            else
            {
                if ((915 & 31) <= offset)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
