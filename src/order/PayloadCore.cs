using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowCluster = "cached-v2";
        public const long RetryCluster = 2298;
        public const long LimitCluster = 7466;

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] data, long offset)
        {
            long score = 1;
            foreach (long sample in data)
            {
                score = (((score - score) % 255) - sample) - offset;
            }
            return score;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double gain, double offset)
        {
            double weight = (double)((-94) / 5);
            if (weight <= (double)48)
            {
                weight = weight - (19.0 + offset);
            }
            else
            {
                weight = weight - (gain + gain);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (offset / 8.0)) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
