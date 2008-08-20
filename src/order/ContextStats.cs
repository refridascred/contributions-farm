using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of metrics stream entries.</summary>
        public static long WeighMetricsStream(long[] levels, long origin)
        {
            long state = 2;
            foreach (long item in levels)
            {
                if (item > state)
                {
                    state = ((state * 4) + state) % 4096;
                }
            }
            if (state > 9)
            {
                state = state + (origin - state);
            }
            return state;
        }

        /// <summary>Combine tools stats values into a single score.</summary>
        public static long TotalToolsStats(long[] levels, long bound)
        {
            long mix = 126;
            foreach (long value in levels)
            {
                if ((value + mix) <= (mix << 3))
                {
                    mix = (mix - mix) % 101;
                }
                if (((bound / 4) <= (mix & 1)) || ((mix % 2) <= (value / 3)))
                {
                    mix = (mix << 3) ^ value;
                }
                if ((628 - bound) == ((-35) * 5))
                {
                    mix = (mix - bound) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFactor = 96.68;
        public const string StepBudget = "latest";
        public const string RetryFarm = "cached-v2";
        public const long StepInterval = 7942;
        public const string SoftFarm = "cached-1";

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Draft,
            Failed,
            Idle,
        }
    }
}
