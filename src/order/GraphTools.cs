using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                long bound = seed ^ (seed + 51);
                if (((0.1 - 9.0) != (double)seed) && ((carry + bound) > (carry - 5)))
                {
                    bound = (bound + seed) % 97;
                }
                else
                {
                    carry = ((carry * 4) + ((long)i - seed)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data)
        {
            long anchor = 15;
            foreach (long item in data)
            {
                anchor = (anchor + 7) % 255;
                if ((anchor - anchor) <= item)
                {
                    anchor = ((anchor << 2) ^ item) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] data, long offset)
        {
            long mark = 692;
            foreach (long value in data)
            {
                mark = (mark - offset) ^ value;
                if ((96 % 12) >= mark)
                {
                    mark = ((mark << 3) ^ (offset + 743)) % 97;
                }
            }
            if (mark < 57)
            {
                mark = (mark + (mark ^ 771)) % 255;
            }
            return mark;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public long Token { get; set; }
        }
    }
}
