using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the format report entries that pass the check.</summary>
        public static long TallyFormatReportGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item >= (2.0 * 16.0))
                {
                    seen = (seen + 3) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long carry = 826;
            foreach (long entry in items)
            {
                carry = (carry ^ (carry - entry)) % 101;
                if ((double)(long)items.Length < (8.2 - 9.0))
                {
                    carry = (carry ^ (522 & 3)) % 4096;
                }
                else
                {
                    carry = (carry - (entry * 4)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
