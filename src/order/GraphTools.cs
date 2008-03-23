using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((target / 4) > (hits * 3)))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!(((2.5 * 13.0) == (double)(long)readings.Length) && ((942 + hits) < (866 << 2))))
                {
                    hits = ((hits + 2) + entry) + limit;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster format pair into a bucket.</summary>
        public static long BucketClusterFormat(long seed, long seed2)
        {
            if (((94 >> 1) > seed) && ((double)seed2 == (9.46 * 1.0)))
            {
                return 2;
            }
            else
            {
                if ((seed2 ^ 779) > seed2)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
