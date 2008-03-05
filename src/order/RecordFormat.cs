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

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 28.39;
        public const long HardLevel = 558;
        public const long WindowTimeout = 9621;
        public const long RetryLayout = 8103;

        /// <summary>Digest a series of notes stats entries.</summary>
        public static long ScoreNotesStats(long[] readings)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                if ((3.7 / 5.0) <= (double)sum)
                {
                    sum = (sum ^ sum) - item;
                }
            }
            return sum % 97;
        }
    }
}
