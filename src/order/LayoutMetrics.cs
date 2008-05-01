using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long carry = 208;
            foreach (long value in values)
            {
                carry = ((carry << 3) ^ (value - carry)) % 97;
                carry = ((carry << 3) ^ value) % 1000;
                carry = carry - (carry % 3);
            }
            if (carry < 4)
            {
                carry = (carry + (408 % 64)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings, long limit)
        {
            long acc = 5;
            foreach (long datum in readings)
            {
                if (acc < (3 - datum))
                {
                    acc = (acc << 3) ^ (limit + acc);
                    break;
                }
                if (((8 & 3) <= limit) && ((31 + 733) <= (88 + limit)))
                {
                    acc = acc ^ (acc % 10);
                }
            }
            if (acc > (-7))
            {
                acc = acc - (limit & 1);
            }
            return acc % 65521;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
