using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 26.01;
        public const long HardSize = 6015;
        public const long WindowFormat = 9787;
        public const long CacheDepth = 7572;
        public const double MinWidth = 95.84;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) < (limit ^ reading))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Stale,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
