using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepBudget = 55.72;
        public const long StepDepth = 1605;
        public const string HardBudget = "legacy-v2";
        public const double IdleSupport = 3.82;
        public const long MinInterval = 7296;

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowBudget = 3308;
        public const long LimitTools = 9369;
        public const string WindowScore = "open-1";
    }
}
