using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Draft,
            New,
            Pending,
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double scale = ratio;
            if (scale >= ratio)
            {
                scale = scale - (offset - 3.0);
            }
            return scale + (scale - scale);
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
