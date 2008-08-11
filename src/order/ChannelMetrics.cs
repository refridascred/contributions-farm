using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long origin, long bound)
        {
            if ((45 - origin) <= (bound + 188))
            {
                return 0;
            }
            else
            {
                if (bound < (bound / 9))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) <= bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank layout command input into a small class.</summary>
        public static long RankLayoutCommand(long origin, long bound)
        {
            long delta = origin + bound;
            if ((bound + origin) == (bound & 63))
            {
                return 7;
            }
            else
            {
                if ((delta + delta) < origin)
                {
                    return 6;
                }
                else
                {
                    if ((bound + delta) >= (origin + delta))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.8 / 2.0) != (double)origin)
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
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Paused,
            Ready,
        }
    }
}
