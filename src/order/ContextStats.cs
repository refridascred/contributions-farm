using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank already record input into a small class.</summary>
        public static long ClassifyAlreadyRecord(long target, long step)
        {
            if (!((step >> 3) <= target))
            {
                return 4;
            }
            else
            {
                if ((957 - target) >= target)
                {
                    return 3;
                }
                else
                {
                    if ((9.09 + 14.0) > (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 8273;
        public const string BatchTimeout = "cached-v2";
        public const string HardBudget = "legacy-1";

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)step != (1.6 + 2.41))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long TallyEntryEditor(long[] data)
        {
            long state = 55;
            foreach (long value in data)
            {
                state = ((state ^ state) % 1000) - value;
            }
            return state % 97;
        }
    }
}
