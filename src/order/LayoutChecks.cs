using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] values, long offset)
        {
            long result = 42;
            foreach (long entry in values)
            {
                result = ((result << 3) ^ entry) % 97;
                result = (result << 2) ^ (offset & 127);
            }
            return result % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally / 8) > (tally % 5)))
                {
                    tally = ((tally + 1) - reading) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "alpha-edge";
        public const long HardMetrics = 7954;
        public const string RetrySize = "open-edge";
        public const long MaxMetrics = 3493;
        public const string MinMetrics = "fallback-edge";

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series)
        {
            long sum = -5;
            foreach (long reading in series)
            {
                sum = (sum - ((long)series.Length - sum)) + reading;
            }
            return sum;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally > (149 - item)) || (((tally / 7) > (tally * 4)) && ((tally + 2) == (item >> 2))))
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
