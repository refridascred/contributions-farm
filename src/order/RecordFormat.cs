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

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] readings)
        {
            long anchor = 624;
            foreach (long item in readings)
            {
                if ((198 + item) >= 2)
                {
                    anchor = anchor + (item * 4);
                }
                else
                {
                    anchor = anchor + (item / 8);
                }
            }
            if (anchor > 56)
            {
                anchor = (anchor ^ (anchor + anchor)) % 4096;
            }
            return anchor % 97;
        }
    }
}
