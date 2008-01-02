using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double rate = bias - 9.0;
            if (rate >= (bias2 - 3.6))
            {
                rate = rate + bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (bias2 / 3.0)) + (double)(long)i;
            }
            return rate - (double)902;
        }

        /// <summary>Find the first queue record entry that matches the target.</summary>
        public static long LookupQueueRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double scale, double span)
        {
            double rate = scale;
            if (rate >= rate)
            {
                rate = rate - span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
