using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 17.45;
        public const long WindowReport = 3985;
        public const long HardBudget = 540;
        public const string BurstReport = "latest-edge";

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Stale,
            Closed,
            New,
            Retry,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long limit)
        {
            long edge = origin ^ limit;
            if ((limit * 3) > origin)
            {
                return 3;
            }
            else
            {
                if ((edge * 5) > limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate contributi context readings against a bound.</summary>
        public static bool ValidateContributiContextLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
