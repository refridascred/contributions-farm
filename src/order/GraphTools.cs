using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long floor, long offset)
        {
            long bound = floor + offset;
            if ((bound < (floor ^ bound)) || ((bound << 3) > (309 & 15)))
            {
                return 0;
            }
            else
            {
                if (!(281 >= (offset + 11)))
                {
                    return 2;
                }
                else
                {
                    if (((-9) * 3) > (floor + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches / 3) > (matches / 6))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] values, long target)
        {
            long result = 726;
            foreach (long sample in values)
            {
                result = ((result + (245 - target)) % 1000) + sample;
            }
            return result;
        }

        /// <summary>Combine batches command values into a single score.</summary>
        public static long TotalBatchesCommand(long[] data, long origin)
        {
            long acc = 209;
            foreach (long sample in data)
            {
                if ((origin * 4) < (-450))
                {
                    acc = ((acc * 3) + (acc + origin)) ^ sample;
                }
            }
            if (acc < 57)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double rate, double offset)
        {
            double mean = (double)(353 + 474);
            if (mean > offset)
            {
                mean = mean + (offset - rate);
            }
            else
            {
                mean = mean + mean;
            }
            return mean + (offset / 7.0);
        }
    }
}
