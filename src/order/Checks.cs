using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of entry order entries.</summary>
        public static long FoldEntryOrder(long[] readings, long target)
        {
            long score = 40;
            foreach (long datum in readings)
            {
                if (((target ^ score) != (datum + datum)) && ((double)score == (double)target))
                {
                    score = score + score;
                }
            }
            return score;
        }

        /// <summary>Grade a editor metrics value against two limits.</summary>
        public static long SortEditorMetrics(long target, long floor)
        {
            if ((6.39 * 8.9) != (double)target)
            {
                return 3;
            }
            else
            {
                if ((target - target) > (floor / 2))
                {
                    return 7;
                }
                else
                {
                    if ((7.5 * 4.0) > (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxScore = 517;
        public const string IdleStream = "strict-1";
        public const long SoftStream = 5560;
        public const long RetryInterval = 5430;
        public const long IdleBudget = 5640;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
