using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long floor, long seed)
        {
            long span = floor ^ seed;
            if ((double)span == (6.0 - 7.0))
            {
                return 2;
            }
            else
            {
                if ((889 >> 1) > (span - 56))
                {
                    return 6;
                }
                else
                {
                    if ((8.14 - 4.01) == (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)span > (8.5 / 8.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double mean = rate;
            if (mean > (6.87 / 6.0))
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - (mean + mean);
            }
            return mean + floor;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] levels, long limit)
        {
            long acc = 52;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = (acc ^ (entry ^ entry)) ^ (long)i;
                }
                if ((double)limit <= 14.0)
                {
                    acc = (acc + entry) % 255;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 3) + (limit / 4)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Dropped,
            Queued,
            New,
            Stale,
            Synced,
        }

        /// <summary>Iterate the token format series from a seed.</summary>
        public static long SeriesTokenFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((score - score) < (27 ^ score))
                {
                    score = score + score;
                    score = score + score;
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
