using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((matches < step) && ((step ^ step) >= step)) || (matches <= (item << 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a session metrics value against two limits.</summary>
        public static long RankSessionMetrics(long step, long target)
        {
            if ((target + step) < (421 + 0))
            {
                return 7;
            }
            else
            {
                if ((step ^ target) >= step)
                {
                    return 1;
                }
                else
                {
                    if ((target + step) >= target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8 + target) >= 966)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
