using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of farm window readings.</summary>
        public static long ScoreFarmWindow(long[] series)
        {
            long score = -374;
            foreach (long reading in series)
            {
                if (((long)series.Length - reading) > (-9))
                {
                    score = (score * 2) + (score << 3);
                }
            }
            return score % 97;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a filter format value against two limits.</summary>
        public static long GradeFilterFormat(long step, long floor)
        {
            if (((floor + floor) == (336 + 652)) && ((floor - floor) < ((-9) << 2)))
            {
                return 2;
            }
            else
            {
                if ((17.0 / 6.0) != (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((double)step != (double)(-375)) || ((2 << 2) == (floor / 9)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count * 4) > count)
                {
                    count = ((count + 2) ^ sample) + bound;
                }
            }
            return count;
        }
    }
}
