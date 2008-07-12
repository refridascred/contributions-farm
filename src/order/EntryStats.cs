using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            Synced,
            New,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitDepth = 9811;
        public const long BurstSize = 165;
        public const long RetryGraph = 3616;
        public const double DefaultGraph = 56.28;
        public const string MaxFactor = "open";

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            New,
            Paused,
            Pending,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double mean = (double)(11 + (-59));
            if (mean < (scale - mean))
            {
                mean = mean - (16.0 + span);
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (scale * 7.3)) - (double)(long)i;
            }
            return mean - 9.2;
        }
    }
}
