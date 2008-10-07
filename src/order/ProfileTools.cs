using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long origin)
        {
            if (((-362) & 7) >= (origin >> 4))
            {
                return 2;
            }
            else
            {
                if (step >= (0 & 7))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value - matches) > matches))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 21.25;
        public const double LimitCache = 6.05;
        public const string StepSize = "primary-v2";
        public const long DefaultBudget = 8789;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((8.1 * 4.0) <= (double)(long)i)
                {
                    state = (state + (state + state)) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
