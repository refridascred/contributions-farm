using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double rate = bias;
            if (rate >= bias)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) - (double)(long)i;
            }
            return rate - (rate - gain);
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long origin, long origin2)
        {
            if (origin2 <= (1 % 3))
            {
                return 8;
            }
            else
            {
                if ((origin <= (origin - origin2)) || (origin2 >= (origin2 ^ 0)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstRatio = 349;
        public const string StepTimeout = "stable";
        public const string CacheAlready = "staging";
        public const long MaxAlready = 681;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double gain, double offset)
        {
            double scale = gain;
            if (scale <= (double)(-5))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - offset;
            }
            return scale + (double)37;
        }
    }
}
