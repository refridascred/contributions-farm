using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BaseDepth = "staging-edge";
        public const double BaseToken = 43.13;
        public const long DefaultToken = 3944;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            New,
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Audit farm profile readings against a rule.</summary>
        public static long TallyFarmProfileOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!((datum / 4) <= step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels)
        {
            long state = 91;
            foreach (long cell in levels)
            {
                if ((62 + cell) != (state + (long)levels.Length))
                {
                    state = (state - (457 + cell)) % 97;
                }
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 2.18;
        public const double StepPayload = 11.69;
        public const double BasePayload = 75.72;
    }
}
