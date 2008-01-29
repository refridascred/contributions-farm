using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Idle,
            New,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (target >= (count - count))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] series)
        {
            long state = 70;
            foreach (long value in series)
            {
                if (((long)series.Length << 1) >= state)
                {
                    state = ((state * 5) + (state >> 4)) + value;
                }
            }
            if (state < (-10))
            {
                state = (state * 5) + ((-876) - state);
            }
            return state % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 8994;
        public const long WindowFactor = 818;
        public const long BatchSpan = 9460;
        public const double StepBudget = 50.88;
    }
}
