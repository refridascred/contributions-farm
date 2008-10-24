using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long target, long origin)
        {
            if (!((20.0 + 0.3) != (double)origin))
            {
                return 7;
            }
            else
            {
                if ((double)origin != (double)target)
                {
                    return 0;
                }
                else
                {
                    if (((origin + 463) >= (target + target)) || (target >= (origin * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultBudget = 29.71;
        public const string SoftRatio = "latest";
        public const long IdleInterval = 8971;
        public const long BurstBudget = 2272;
        public const long BurstWindow = 9645;
    }
}
