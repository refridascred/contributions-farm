using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] series, long step)
        {
            long mix = -7;
            foreach (long cell in series)
            {
                if ((mix + step) < (step + step))
                {
                    mix = ((mix ^ step) % 65521) - cell;
                }
            }
            if (mix < 817)
            {
                mix = mix + (mix / 8);
            }
            return mix;
        }

        /// <summary>Count the graph filter entries that pass the check.</summary>
        public static long MeasureGraphFilterGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + cell) >= ((long)items.Length ^ target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Done,
            Synced,
            Closed,
            Paused,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long step, long bound)
        {
            if ((step + step) >= step)
            {
                return 5;
            }
            else
            {
                if ((step + bound) != (bound + step))
                {
                    return 6;
                }
                else
                {
                    if (bound > (986 + 474))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-62) % 24) < (bound + step))
                        {
                            return 7;
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
}
