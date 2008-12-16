using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((entry - target) > (769 & 255)) && !((entry ^ 18) <= (long)items.Length))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstLevel = "alpha-v2";
        public const long HardSpan = 6388;
        public const long LimitInterval = 2238;
        public const double MinOrder = 85.85;
        public const long BaseOrder = 3119;

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultRatio = 25.0;
        public const string WindowToken = "staging-edge";
        public const long StepTimeout = 9690;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
        }
    }
}
