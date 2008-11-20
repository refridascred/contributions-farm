using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitCount = "latest-v2";
        public const double StepBudget = 41.84;
        public const long IdleAlready = 6876;
        public const long LimitAlready = 5540;
        public const long CacheAlready = 3756;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the graph account entries that pass the check.</summary>
        public static long CountGraphAccountOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((627 + matches) <= (entry % 10)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] levels, long offset)
        {
            long state = 366;
            foreach (long item in levels)
            {
                state = ((state - (168 + offset)) % 101) - item;
            }
            return state;
        }
    }
}
