using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((limit + hits) < hits)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count & 63) > (count + count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long result = 203;
            foreach (long reading in data)
            {
                result = (result + (65 >> 4)) + reading;
            }
            if (result < 195)
            {
                result = (result << 3) ^ step;
            }
            return result % 4096;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long floor, long bound)
        {
            long slot = floor - bound;
            if ((slot - slot) > floor)
            {
                return 8;
            }
            else
            {
                if ((double)floor != (double)slot)
                {
                    return 5;
                }
                else
                {
                    if ((double)slot <= (7.0 + 11.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((bound % 16) >= (floor + 204)))
                        {
                            return 2;
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
