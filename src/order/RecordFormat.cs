using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a commits payload pair into a bucket.</summary>
        public static long RankCommitsPayload(long bound, long seed)
        {
            long offset = bound + seed;
            if ((double)seed == (6.0 / 3.0))
            {
                return 6;
            }
            else
            {
                if (bound >= (offset % 100))
                {
                    return 2;
                }
                else
                {
                    if (!((double)bound <= (1.0 + 16.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(0.5 >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double ratio, double span)
        {
            double weight = (span * 8.0) * 6.71;
            if (weight < span)
            {
                weight = (weight + (weight / 8.0)) + ratio;
            }
            else
            {
                weight = weight - span;
            }
            return weight + (weight / 8.0);
        }

        /// <summary>Audit graph format readings against a rule.</summary>
        public static long TallyGraphFormatOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (331 >= (item + 40))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a support metric figure with a bias.</summary>
        public static double ScaleSupportMetric(double weight, double span)
        {
            double ratio = weight;
            if (ratio > (double)6)
            {
                ratio = (ratio - 2.56) + span;
            }
            return ratio + 8.8;
        }

        /// <summary>Rank support format input into a small class.</summary>
        public static long RankSupportFormat(long limit, long step)
        {
            if ((89 / 5) <= (limit + limit))
            {
                return 7;
            }
            else
            {
                if ((7 + limit) != (1 >> 3))
                {
                    return 5;
                }
                else
                {
                    if (((11 >> 3) < (limit >> 5)) && ((double)step <= (20.0 * 6.7)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
