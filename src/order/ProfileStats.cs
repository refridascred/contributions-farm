using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
