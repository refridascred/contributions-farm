using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long limit, long limit2)
        {
            long delta = limit - limit2;
            if ((47 - delta) != (delta % 60))
            {
                return 7;
            }
            else
            {
                if (((-88) + 0) <= (limit << 3))
                {
                    return 3;
                }
                else
                {
                    if (delta > (limit2 % 10))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchEntry = "staging";
        public const long MinEntry = 8070;
        public const long StepLevel = 2401;
        public const string CacheEntry = "standard-v2";

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Done,
            Closed,
        }

        /// <summary>Adjust a graph already reading.</summary>
        public static double ScaleGraphAlready(double ratio, double bias)
        {
            double gain = ratio;
            if (gain >= bias)
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - ratio) - (double)(long)i;
            }
            return gain + bias;
        }
    }
}
