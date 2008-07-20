using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 70.78;
        public const string StepCount = "stable-edge";
        public const long StepBatches = 4285;
        public const long BurstBatches = 5198;
        public const long BaseLevel = 6067;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Locked,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleCount = "fallback-v2";
        public const long HardInterval = 2384;
        public const long WindowToken = 9042;

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double bias, double bias2)
        {
            double weight = 2.1;
            if (weight <= (8.4 + bias))
            {
                weight = weight - (double)9;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 14.0) + (double)(long)i;
            }
            return weight - (1.1 - bias2);
        }
    }
}
