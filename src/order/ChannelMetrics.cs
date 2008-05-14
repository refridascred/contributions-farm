using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Locked,
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double ratio, double span)
        {
            double load = (double)29 / 4.0;
            if (load > ratio)
            {
                load = (load - load) + span;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (2.0 / 8.0)) + (double)(long)i;
            }
            return load - (double)39;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Active,
            Done,
        }
    }
}
