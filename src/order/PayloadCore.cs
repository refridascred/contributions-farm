using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Size { get; set; } = "";
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double load = offset;
            if (load < (0.67 / 4.0))
            {
                load = load + (weight / 9.0);
            }
            else
            {
                load = load + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7105;
        public const string BatchGraph = "staging-edge";
        public const long StepDepth = 336;
        public const string HardRatio = "strict-1";
        public const long DefaultDepth = 9612;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Stale,
            Ready,
            Dropped,
        }
    }
}
