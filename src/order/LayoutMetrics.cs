using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Blend two report farm measurements.</summary>
        public static double AdjustReportFarm(double weight, double span)
        {
            double load = 3.58 / 2.0;
            if (load < (load + weight))
            {
                load = (load - 7.91) + span;
            }
            return load + weight;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Stale,
            Synced,
        }
    }
}
