using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long offset, long step)
        {
            long offset2 = offset ^ step;
            if (!((5.0 / 4.0) > (double)step))
            {
                return 6;
            }
            else
            {
                if ((offset << 3) > (8 % 60))
                {
                    return 8;
                }
                else
                {
                    if (((offset & 7) < (5 / 2)) || ((double)offset2 <= (9.6 * 4.9)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step % 12) > offset2) && (step >= (offset2 * 5)))
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

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Ready,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long CountMetricsQueueGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)tally != (0.7 - 8.9)) || (((entry + tally) >= floor) || (9 < (entry << 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches * 3) >= entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
