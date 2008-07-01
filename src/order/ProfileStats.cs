using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double gain2 = (double)((-7) % 3);
            if (gain2 > (double)375)
            {
                gain2 = ((gain2 + (double)(-4)) + gain) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - (double)(-334);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data)
        {
            long state = 41;
            foreach (long item in data)
            {
                state = state - (item - item);
            }
            if (state < 72)
            {
                state = (state - state) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
