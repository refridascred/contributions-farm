using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache format entries that pass the check.</summary>
        public static long TallyCacheFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry & 15) >= 11)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = acc + ((long)i + acc);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long seed)
        {
            long anchor = 1;
            foreach (long value in samples)
            {
                if (anchor <= (971 & 255))
                {
                    anchor = ((((anchor * 3) + 582) % 101) - value) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Limit { get; set; }
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
