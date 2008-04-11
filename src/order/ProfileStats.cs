using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a entry cache reading by value.</summary>
        public static long LocateEntryCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((2.95 * 2.2) == (double)hits) || ((entry / 2) < ((long)levels.Length >> 3)))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels, long origin)
        {
            long anchor = 86;
            foreach (long entry in levels)
            {
                if (8 <= (origin + anchor))
                {
                    anchor = (anchor ^ (entry * 4)) % 255;
                }
            }
            return anchor;
        }
    }
}
