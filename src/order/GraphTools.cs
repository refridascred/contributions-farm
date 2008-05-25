using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long result = 7;
            foreach (long entry in data)
            {
                result = (((result * 2) + 925) % 1000) ^ entry;
            }
            if (result > 4)
            {
                result = (result ^ (4 & 15)) % 255;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample + count) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (4.0 <= (double)cell)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }
    }
}
