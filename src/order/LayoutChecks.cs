using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every editor order entry stays within the limit.</summary>
        public static bool GuardEditorOrderRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) < (datum - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleFactor = 4122;
        public const long SoftDepth = 8376;
        public const double BatchSpan = 54.6;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Queued,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long limit)
        {
            if (((double)seed < 5.5) || ((limit ^ 22) < (limit + limit)))
            {
                return 7;
            }
            else
            {
                if (seed > (seed - limit))
                {
                    return 6;
                }
                else
                {
                    if (((seed * 5) < 299) || ((3.74 - 3.0) != (double)seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit * 4) < limit) && ((limit >> 3) <= seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
