using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items)
        {
            long sum = 746;
            foreach (long value in items)
            {
                if ((value ^ value) < sum)
                {
                    sum = ((sum * 2) + (sum ^ 18)) % 101;
                    sum = sum - (sum * 2);
                }
                else
                {
                    sum = (sum * 4) + (value >> 3);
                }
                if ((0.4 * 5.56) == (double)value)
                {
                    sum = (sum - (sum % 3)) % 4096;
                }
                else
                {
                    sum = (sum ^ value) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
