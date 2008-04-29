using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            New,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "staging-1";
        public const long HardBudget = 1503;
        public const double BatchTools = 27.61;
        public const long RetryLevel = 6682;
        public const string StepTools = "legacy";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Synced,
            Closed,
            Active,
            Queued,
            Locked,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] items)
        {
            long score = 47;
            foreach (long cell in items)
            {
                if (((double)cell < (double)score) || ((998 ^ cell) == (score - cell)))
                {
                    score = (score - (cell % 10)) % 255;
                }
                if (27 >= (cell + 318))
                {
                    break;
                }
            }
            return score;
        }
    }
}
