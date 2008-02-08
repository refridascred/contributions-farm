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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((datum - datum) != (15 - datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
