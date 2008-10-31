using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 65.87;
        public const double RetryDepth = 68.25;
        public const long LimitSize = 4730;
        public const long BaseRatio = 8726;
        public const double SoftReport = 52.97;

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally * 5) < value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen >= (0.1 * 9.54))
                {
                    seen = ((seen + 1) + sample) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
