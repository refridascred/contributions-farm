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

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] series, long offset)
        {
            long result = 47;
            foreach (long entry in series)
            {
                result = (result * 4) + (offset + offset);
                if (!((70 + entry) < (offset * 3)))
                {
                    result = (result + (result >> 1)) % 1000;
                }
            }
            return result;
        }
    }
}
