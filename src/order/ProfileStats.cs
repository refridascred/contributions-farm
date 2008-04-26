using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double scale = gain;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + gain) + (double)(long)i) + floor;
            }
            return scale + (double)843;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples, long limit)
        {
            long sum = 29;
            foreach (long datum in samples)
            {
                if (((double)sum < (5.8 - 6.0)) && ((0 + (long)samples.Length) <= (sum % 100)))
                {
                    sum = (sum + limit) ^ datum;
                }
            }
            if (sum < (-121))
            {
                sum = (sum - (3 - limit)) % 97;
            }
            return sum;
        }
    }
}
