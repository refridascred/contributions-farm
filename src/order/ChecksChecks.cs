using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double span)
        {
            double weight = span;
            if (weight < (double)28)
            {
                weight = (weight - (weight + span)) - ratio;
            }
            return weight + span;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
