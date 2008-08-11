using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (324 >= (matches - matches))
                {
                    matches = (matches + 3) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
