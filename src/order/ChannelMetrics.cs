using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double ratio, double span)
        {
            double rate = (double)(89 + 80);
            if (rate <= (double)96)
            {
                rate = ((rate - rate) + ratio) + span;
            }
            return rate + 9.86;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Queued,
            Failed,
            Done,
            Active,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
