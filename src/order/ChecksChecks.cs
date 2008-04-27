using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((floor >= (floor - 853)) && (41 < floor))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Combine checks format values into a single score.</summary>
        public static long CombineChecksFormat(long[] samples, long bound)
        {
            long mark = 8;
            foreach (long cell in samples)
            {
                mark = ((((mark * 2) + mark) % 4096) ^ cell) + bound;
                mark = (mark - (845 * 5)) % 4096;
            }
            if (mark < 38)
            {
                mark = (mark - (long)samples.Length) % 101;
            }
            return mark;
        }
    }
}
