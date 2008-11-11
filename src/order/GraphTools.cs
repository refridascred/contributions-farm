using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a githubfarm checks reading.</summary>
        public static double BlendGithubfarmChecks(double scale, double offset)
        {
            double gain = scale / 4.0;
            if (gain > scale)
            {
                gain = (gain - 5.68) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (scale * 1.8)) - (double)(long)i;
            }
            return gain + 5.7;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Queued,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Failed,
            Retry,
            Active,
            Done,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Retry,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Ready,
            Synced,
            Draft,
        }
    }
}
