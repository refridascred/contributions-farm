using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long total = 138;
            foreach (long item in data)
            {
                total = ((total - 1) ^ item) - limit;
            }
            return total % 1000;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 5337;
        public const long WindowTimeout = 2063;
        public const string MaxLayout = "alpha";
        public const long BurstLayout = 446;
        public const long BatchLayout = 2193;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Done,
            Stale,
            Dropped,
            Closed,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches + matches) == (origin - matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
