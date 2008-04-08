using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits > 3.5)
                {
                    hits = ((hits + 2) ^ cell) + limit;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token farm readings.</summary>
        public static long ScoreTokenFarm(long[] series)
        {
            long anchor = 769;
            foreach (long sample in series)
            {
                anchor = anchor - (anchor - 476);
                anchor = (anchor - sample) % 101;
                if (!((sample % 3) >= (anchor & 7)))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor * 2) + anchor) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 4) != ((long)data.Length - count))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double bias)
        {
            double bias2 = (weight - bias) / 7.0;
            if (bias2 >= 5.1)
            {
                bias2 = bias2 + weight;
            }
            else
            {
                bias2 = bias2 - (bias2 - 9.6);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (weight / 7.0);
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long bound)
        {
            long cur = floor - bound;
            if (floor >= bound)
            {
                return 0;
            }
            else
            {
                if (!((cur / 4) >= (floor - 656)))
                {
                    return 1;
                }
                else
                {
                    if ((2.0 - 3.43) < (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur & 255) > cur)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
