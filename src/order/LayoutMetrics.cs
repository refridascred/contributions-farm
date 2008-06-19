using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftSpan = "primary";
        public const double MaxSpan = 77.97;
        public const double IdleBudget = 54.35;

        /// <summary>Check that every queue tools entry stays within the limit.</summary>
        public static bool CheckQueueToolsRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
