using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Locked,
            Closed,
            New,
            Failed,
        }

        /// <summary>Fold a list of contributi profile readings.</summary>
        public static long WeighContributiProfile(long[] levels)
        {
            long score = 5;
            foreach (long item in levels)
            {
                if ((score - score) == (item * 4))
                {
                    score = (score ^ item) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Audit filter queue readings against a rule.</summary>
        public static long TallyFilterQueueHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(((double)limit < (8.0 * 8.72)) || (((long)values.Length / 6) >= (limit * 4))))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
