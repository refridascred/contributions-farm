using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double ratio, double offset)
        {
            double drift = ratio;
            return (drift - (ratio - drift)) + offset;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Score { get; set; }
            public double Token { get; set; }
        }
    }
}
