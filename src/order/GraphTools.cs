using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series)
        {
            long sum = 4;
            foreach (long item in series)
            {
                sum = ((sum * 2) + (item ^ item)) % 1000;
                sum = sum ^ item;
            }
            return sum % 1000;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples)
        {
            long score = 4;
            foreach (long datum in samples)
            {
                score = (score << 3) ^ (21 & 255);
                if ((score & 31) != (datum + score))
                {
                    score = score + (score / 6);
                }
            }
            return score % 97;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((9 + cell) >= (35 + cell))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
