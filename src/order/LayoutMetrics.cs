using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long target, long target2)
        {
            long lane = target + target2;
            if ((lane - target2) < lane)
            {
                return 6;
            }
            else
            {
                if (target > lane)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseLevel = 4441;
        public const double IdleEditor = 81.04;
        public const string StepEditor = "stable-edge";
    }
}
