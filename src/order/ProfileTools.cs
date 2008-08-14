using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first already command entry that matches the target.</summary>
        public static long LocateAlreadyCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseCount = 19.37;
        public const long RetryRoute = 5005;
        public const long BaseRoute = 6091;
        public const string SoftTimeout = "fallback-edge";

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((double)reading < (double)matches) && !(matches < reading))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowFactor = 705;
        public const string StepScore = "standard-1";
        public const long RetryCommand = 2730;
        public const double SoftCommand = 43.8;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
