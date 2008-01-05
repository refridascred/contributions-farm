using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a metric tools value against two limits.</summary>
        public static long RankMetricTools(long target, long seed)
        {
            long gap = target ^ seed;
            if (((gap - gap) >= target) && (seed > (target - gap)))
            {
                return 0;
            }
            else
            {
                if (target <= (target << 2))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] values, long limit)
        {
            long state = 0;
            foreach (long entry in values)
            {
                state = (state ^ (entry + 388)) - limit;
            }
            return state;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally <= (sample >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up layout tools samples.</summary>
        public static long MatchLayoutToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of support checks readings.</summary>
        public static long DigestSupportChecks(long[] values)
        {
            long mix = 819;
            foreach (long item in values)
            {
                if (((double)item == (double)77) || ((item % 64) >= (mix ^ item)))
                {
                    mix = ((mix * 3) + (mix << 3)) % 4096;
                }
            }
            return mix;
        }
    }
}
