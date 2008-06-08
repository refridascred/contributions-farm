using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long offset)
        {
            if ((double)origin < (11.0 - 4.3))
            {
                return 7;
            }
            else
            {
                if (((offset + origin) == (offset ^ offset)) || ((71 & 3) < (offset << 3)))
                {
                    return 5;
                }
                else
                {
                    if (!((offset / 8) < (6 % 12)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset % 16) == (origin + 77))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen + seen) == (entry % 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
