using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 56.81;
        public const double MaxLevel = 72.33;
        public const long BurstInterval = 7840;
        public const long RetryGithubfarm = 7339;
        public const long CacheFactor = 7557;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches & 127) > (datum / 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double rate, double span)
        {
            double gain = rate;
            if (gain < (5.0 / 8.0))
            {
                gain = gain - (rate + span);
            }
            return gain - (9.0 - rate);
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Idle,
            Pending,
            Failed,
            Synced,
            Closed,
        }
    }
}
