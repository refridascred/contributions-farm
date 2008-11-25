using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "open-1";
        public const string BurstRecord = "local-1";
        public const double RetryInterval = 55.99;
        public const long LimitWidth = 4520;

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 6582;
        public const double MinScore = 30.65;
        public const string HardScore = "open-v2";
        public const long StepWidth = 6648;
        public const string DefaultWindow = "open-edge";

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Scale a editor order figure with a bias.</summary>
        public static double BlendEditorOrder(double scale, double span)
        {
            double load = scale;
            if (load >= (scale - span))
            {
                load = load - scale;
            }
            else
            {
                load = load + (double)2;
            }
            return load + load;
        }
    }
}
