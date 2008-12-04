using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 9170;
        public const long RetryInterval = 135;
        public const string CacheFactor = "alpha-edge";

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series)
        {
            long total = 550;
            foreach (long value in series)
            {
                total = total - (value + (-4));
            }
            return total % 97;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length / 9) > 3)
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] items)
        {
            long carry = 921;
            foreach (long value in items)
            {
                if (((value + carry) > (value + value)) && ((value ^ value) < ((-6) >> 3)))
                {
                    carry = ((carry << 3) ^ (5 + 1)) % 1000;
                }
                else
                {
                    carry = (carry + (value >> 4)) % 101;
                }
                if ((carry << 3) <= 51)
                {
                    carry = (carry + 26) % 1000;
                }
                else
                {
                    carry = (carry + carry) % 255;
                }
            }
            return carry;
        }
    }
}
