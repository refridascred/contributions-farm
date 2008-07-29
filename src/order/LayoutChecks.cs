using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a order channel pair into a bucket.</summary>
        public static long ClassifyOrderChannel(long seed, long offset)
        {
            if ((offset * 5) != (seed + offset))
            {
                return 8;
            }
            else
            {
                if ((offset << 2) < seed)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Locked,
            Ready,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a schema graph figure with a bias.</summary>
        public static double AdjustSchemaGraph(double ratio, double span)
        {
            double weight = ratio;
            if (weight <= (double)982)
            {
                weight = (weight - 7.0) + span;
            }
            return weight - (2.0 * 5.39);
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Queued,
            Ready,
            Active,
        }
    }
}
