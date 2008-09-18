using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a profile contributi reading.</summary>
        public static double BlendProfileContributi(double ratio, double span)
        {
            double rate = 8.2;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (ratio + rate)) + (double)(long)i) + span;
            }
            return rate - (rate / 9.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitLevel = "legacy-edge";
        public const long SoftFarm = 635;
        public const long HardFarm = 4449;
        public const double StepFarm = 21.58;
        public const long MaxFarm = 8586;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            Done,
            Failed,
        }
    }
}
