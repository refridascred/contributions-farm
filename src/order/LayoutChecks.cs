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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
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
