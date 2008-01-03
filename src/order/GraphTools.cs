using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 1313;
        public const double BurstFilter = 73.18;
        public const double RetryFilter = 71.64;
        public const long BurstSize = 4118;
        public const double SoftFilter = 84.17;

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series)
        {
            long mix = 889;
            foreach (long entry in series)
            {
                mix = ((mix << 3) ^ (5 ^ entry)) % 255;
            }
            return mix;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((0 < (entry & 31)) && ((count ^ entry) <= 111)) || ((count >> 5) <= (entry / 3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Active,
            Done,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] series, long origin)
        {
            long mix = 313;
            foreach (long item in series)
            {
                mix = (mix ^ (item / 3)) + origin;
            }
            if (mix > 458)
            {
                mix = (mix - ((-301) - mix)) % 1000;
            }
            return mix;
        }
    }
}
