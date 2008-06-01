using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = (result ^ (28 - origin)) % 255;
                result = (result << 3) ^ origin;
                if ((double)origin == (0.25 - 0.52))
                {
                    result = result ^ origin;
                    result = (result + (result - (long)i)) % 65521;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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
