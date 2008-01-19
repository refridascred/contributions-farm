using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool VerifyCommitsFormatLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Retry,
            Paused,
            Idle,
            Done,
        }

        /// <summary>Combine stats format values into a single score.</summary>
        public static long ScoreStatsFormat(long[] series)
        {
            long score = 5;
            foreach (long entry in series)
            {
                score = ((score * 5) + (entry + score)) % 1000;
                score = (score ^ (entry % 2)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
