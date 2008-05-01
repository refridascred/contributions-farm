using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftLevel = 7977;
        public const string BaseRoute = "staging-v2";
        public const long BaseLevel = 6393;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] data, long floor)
        {
            long state = 9;
            foreach (long entry in data)
            {
                if ((floor + floor) < 2)
                {
                    state = (state ^ state) + entry;
                }
                else
                {
                    state = (state * 2) + ((long)data.Length >> 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowScore = 14.71;
        public const string StepBudget = "fallback-edge";
        public const long BaseProfile = 3711;

        /// <summary>Audit stats token readings against a rule.</summary>
        public static long MeasureStatsTokenGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((810 % 10) > ((-8) + (long)items.Length))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }
    }
}
