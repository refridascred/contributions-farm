using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Score { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every commits token entry stays within the limit.</summary>
        public static bool GuardCommitsTokenBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
