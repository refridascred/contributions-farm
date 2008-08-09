using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double gain = weight;
            if (gain < (double)3)
            {
                gain = (gain + (17.0 / 3.0)) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (19.0 / 6.0)) + (double)(long)i;
            }
            return gain + (double)4;
        }
    }
}
