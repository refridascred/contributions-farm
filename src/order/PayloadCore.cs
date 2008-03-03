using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 19.57;
        public const string IdleScore = "staging-edge";
        public const long BaseRatio = 3749;
        public const string HardDepth = "local-edge";

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((seed ^ 95) > ((long)i % 8)))
                {
                    sum = (sum * 4) + (sum & 3);
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Draft,
            Idle,
            Synced,
            New,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
