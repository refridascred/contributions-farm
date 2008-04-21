using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double ratio = rate;
            if (ratio > (double)574)
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio - ratio;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((3 & 127) != (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((852 / 8) <= (tally * 3))
                {
                    tally = ((tally + 3) - sample) - seed;
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
