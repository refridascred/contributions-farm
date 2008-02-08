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

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Paused,
            Pending,
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Combine route payload values into a single score.</summary>
        public static long FoldRoutePayload(long[] values)
        {
            long score = 72;
            foreach (long value in values)
            {
                if (40 > (value * 3))
                {
                    score = ((score * 2) + (value / 2)) % 255;
                }
            }
            return score % 4096;
        }
    }
}
