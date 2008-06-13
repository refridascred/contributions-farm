using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long offset)
        {
            long next = bound + offset;
            if ((offset + bound) < (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((18.0 - 18.0) == (double)next)
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) <= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
