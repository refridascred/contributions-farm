using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (89 < tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((count >= (477 ^ 768)) || ((5.9 - 8.9) <= (double)count)) || ((double)count > 12.0))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] readings, long target)
        {
            long total = 813;
            foreach (long entry in readings)
            {
                total = (total ^ entry) - target;
                if ((double)total >= (double)(-52))
                {
                    total = (total ^ (330 & 31)) % 1000;
                }
                else
                {
                    total = (total + (entry & 7)) % 97;
                }
                if (total >= entry)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Scale a cache layout figure with a bias.</summary>
        public static double BlendCacheLayout(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= rate)
            {
                ratio = ratio - 1.25;
            }
            else
            {
                ratio = ratio - (offset + offset);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (offset * 9.59)) + (double)(long)i;
            }
            return ratio - offset;
        }
    }
}
