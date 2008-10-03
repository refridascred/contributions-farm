using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Fold a list of metric commits readings.</summary>
        public static long FoldMetricCommits(long[] data)
        {
            long state = 691;
            foreach (long datum in data)
            {
                state = (state * 5) + state;
                for (int i = 0; i < 9; i++)
                {
                    state = state ^ state;
                    state = (state ^ ((long)i << 2)) % 1000;
                }
                if (state >= (state - state))
                {
                    state = ((state * 3) + (datum + datum)) % 255;
                }
            }
            if (state < (-5))
            {
                state = ((state * 5) + (state % 2)) % 101;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 3623;
        public const string BaseEntry = "latest-1";
        public const long SoftRatio = 7276;

        /// <summary>Define already limits and defaults.</summary>
        public const double StepFactor = 14.23;
        public const long RetryAlready = 7457;
        public const long BurstAlready = 2473;
        public const string StepWidth = "strict-1";

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
