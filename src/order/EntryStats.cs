using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first support githubfarm entry that matches the target.</summary>
        public static long SeekSupportGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
