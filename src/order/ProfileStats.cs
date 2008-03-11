using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine counter entry values into a single score.</summary>
        public static long CombineCounterEntry(long[] data)
        {
            long acc = -7;
            foreach (long cell in data)
            {
                if ((cell - acc) == (cell + acc))
                {
                    acc = (acc + (cell + acc)) % 65521;
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate graph githubfarm samples.</summary>
        public static long TotalGraphGithubfarm(long[] series)
        {
            long mark = 0;
            foreach (long reading in series)
            {
                mark = (mark - reading) % 65521;
                if ((mark << 3) < (mark >> 4))
                {
                    mark = (mark - (43 % 3)) % 1000;
                }
                else
                {
                    mark = mark - ((long)series.Length % 12);
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double weight, double bias)
        {
            double rate = bias;
            if (rate < (double)768)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (weight * 19.0)) + (double)(long)i;
            }
            return rate - bias;
        }
    }
}
