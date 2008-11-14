using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length < (double)seed)
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi entry value against two limits.</summary>
        public static long BucketContributiEntry(long origin, long bound)
        {
            long bound2 = origin - bound;
            if ((origin <= bound) || ((-698) >= (bound + bound)))
            {
                return 4;
            }
            else
            {
                if ((bound2 * 4) > (bound + bound2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) != (offset + offset))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
