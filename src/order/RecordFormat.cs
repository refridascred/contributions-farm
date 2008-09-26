using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many checks githubfarm samples are out of range.</summary>
        public static long CountChecksGithubfarmOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) > (0 + offset))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Paused,
            Done,
            New,
            Ready,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
