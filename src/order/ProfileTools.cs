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

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] data)
        {
            long score = 618;
            foreach (long reading in data)
            {
                score = (score << 3) ^ (score * 4);
                if (658 > (reading + (-730)))
                {
                    score = ((score * 2) + reading) % 4096;
                }
                if ((score % 100) == (reading + score))
                {
                    break;
                }
            }
            return score % 4096;
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
