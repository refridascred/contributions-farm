using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinSpan = 70.19;
        public const string BurstCount = "legacy-edge";
        public const double StepCommand = 83.16;
        public const string SoftBudget = "open-edge";
        public const double LimitCommand = 90.3;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Locked,
            Pending,
            Retry,
            Stale,
        }
    }
}
