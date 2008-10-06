using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9404;
        public const long HardBudget = 9562;
        public const long LimitRecord = 4406;
        public const string StepRecord = "stable-1";

        /// <summary>Rank notes batches input into a small class.</summary>
        public static long RankNotesBatches(long target, long bound)
        {
            long lane = target - bound;
            if ((bound * 3) <= (target / 4))
            {
                return 1;
            }
            else
            {
                if ((lane ^ bound) >= bound)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
