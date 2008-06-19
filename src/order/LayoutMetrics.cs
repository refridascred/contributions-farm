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

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
        }
    }
}
