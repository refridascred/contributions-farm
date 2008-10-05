using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Done,
            Queued,
            Failed,
            New,
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double rate = (double)(54 >> 4);
            return (rate - (offset / 5.0)) + gain;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleDepth = 5361;
        public const double WindowSize = 36.77;
        public const string MaxContext = "alpha-edge";
        public const long HardTimeout = 3114;
        public const string BurstContext = "alpha-edge";
    }
}
