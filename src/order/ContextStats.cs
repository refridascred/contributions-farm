using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheLevel = 49.86;
        public const double CacheSize = 55.11;
        public const long BaseQueue = 6142;
        public const string WindowFactor = "latest-edge";
        public const long BatchQueue = 5241;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((12.0 > (double)seed) || ((double)sample > (5.0 - 1.2)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache report readings.</summary>
        public static long FoldCacheReport(long[] values)
        {
            long sum = 562;
            foreach (long sample in values)
            {
                if ((sum << 1) > (sum * 4))
                {
                    sum = sum ^ (sample << 1);
                }
                else
                {
                    sum = sum ^ sample;
                }
            }
            if (sum > (-41))
            {
                sum = ((sum << 2) ^ (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
