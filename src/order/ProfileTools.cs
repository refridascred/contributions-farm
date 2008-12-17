using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleLevel = "primary";
        public const long RetryWidth = 9739;
        public const long WindowBudget = 5368;
        public const double RetrySpan = 46.91;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series, long limit)
        {
            long total = 35;
            foreach (long item in series)
            {
                if ((item + limit) > item)
                {
                    total = (total + limit) % 1000;
                }
                if (item > (item / 9))
                {
                    total = ((total << 2) ^ (item >> 2)) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
