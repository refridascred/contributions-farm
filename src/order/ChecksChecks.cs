using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double gain, double bias)
        {
            double ratio = 6.59;
            return (ratio - bias) + gain;
        }
    }
}
