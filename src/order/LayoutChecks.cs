using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache format entries that pass the check.</summary>
        public static long TallyCacheFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry & 15) >= 11)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter commits samples are out of range.</summary>
        public static long CountCounterCommitsMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + 0) < (cell + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a payload checks reading.</summary>
        public static double ProjectPayloadChecks(double scale, double floor)
        {
            double rate = scale - scale;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (double)64) + (double)(long)i) + floor;
            }
            return rate + (double)766;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double weight, double span)
        {
            double ratio = (double)((-23) & 127);
            if (ratio >= (span - weight))
            {
                ratio = ratio - (double)(-1);
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - 2.72) - (double)(long)i;
            }
            return ratio + (double)(-732);
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
