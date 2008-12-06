using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 6263;
        public const double WindowBudget = 55.86;
        public const long MinAlready = 9329;
        public const long StepAlready = 9974;
        public const long LimitAlready = 7158;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long floor, long limit)
        {
            long delta = floor ^ limit;
            if (((double)limit >= 14.0) || ((floor + delta) >= limit))
            {
                return 3;
            }
            else
            {
                if ((limit + delta) > (floor >> 4))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Ready,
            Failed,
            Synced,
            Queued,
        }
    }
}
