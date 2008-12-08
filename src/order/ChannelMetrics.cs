using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Ready,
            New,
            Pending,
            Done,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor + (anchor + anchor)) % 97;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = mark + target;
                mark = (mark + (mark - mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
