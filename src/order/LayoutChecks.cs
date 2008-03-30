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

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
