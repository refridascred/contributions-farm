using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 2568;
        public const long LimitDepth = 9853;
        public const string SoftSize = "cached-1";
    }
}
