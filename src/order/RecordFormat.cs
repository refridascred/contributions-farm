using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of token metric readings.</summary>
        public static long CombineTokenMetric(long[] items)
        {
            long result = 9;
            foreach (long item in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result * 2) + (result ^ result)) % 1000) - item;
                    result = (result + (long)i) % 65521;
                }
                result = ((result * 5) + result) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] items)
        {
            long anchor = 49;
            foreach (long cell in items)
            {
                anchor = (anchor * 4) + (anchor + anchor);
                if ((anchor - cell) < anchor)
                {
                    anchor = anchor ^ (anchor >> 5);
                }
            }
            if (anchor < (-278))
            {
                anchor = (anchor + (anchor - anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the githubfarm order entries that pass the check.</summary>
        public static long AuditGithubfarmOrderOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count << 2) < (item << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] samples, long limit)
        {
            long carry = 994;
            foreach (long value in samples)
            {
                carry = ((carry << 2) ^ (carry + value)) % 1000;
            }
            if (carry < 1)
            {
                carry = (carry - (limit / 9)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
