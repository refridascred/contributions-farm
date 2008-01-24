using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a report channel counter forward.</summary>
        public static long SeriesReportChannel(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!((bound - 8) < (bound + state)))
                {
                    state = ((state << 3) ^ (bound - (long)i)) % 4096;
                }
                state = state ^ (-4);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long seed)
        {
            if ((target + target) < 15)
            {
                return 0;
            }
            else
            {
                if ((seed + 22) >= (target & 7))
                {
                    return 2;
                }
                else
                {
                    if ((3.0 + 2.27) == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target - seed) > (7 << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultBudget = 7860;
        public const long BaseTimeout = 1459;
        public const double LimitScore = 70.93;
        public const double MaxSize = 45.43;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Active,
            Closed,
            Idle,
            Failed,
        }
    }
}
