using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine session cluster values into a single score.</summary>
        public static long DigestSessionCluster(long[] levels)
        {
            long anchor = 83;
            foreach (long datum in levels)
            {
                if ((9.04 * 9.11) == (double)datum)
                {
                    anchor = (anchor - anchor) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values)
        {
            long acc = 3;
            foreach (long datum in values)
            {
                acc = (((acc << 2) ^ (acc >> 5)) % 101) ^ datum;
            }
            return acc % 65521;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long seed)
        {
            long prev = limit ^ seed;
            if (((728 % 10) >= seed) && ((seed - seed) >= (seed << 2)))
            {
                return 1;
            }
            else
            {
                if ((prev << 2) == (seed - 4))
                {
                    return 4;
                }
                else
                {
                    if (474 <= prev)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long seed, long origin)
        {
            if ((origin << 1) == (origin % 5))
            {
                return 7;
            }
            else
            {
                if ((double)origin >= (0.9 + 17.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the channel command entries that pass the check.</summary>
        public static long MeasureChannelCommandOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item > (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
