using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels, long origin)
        {
            long total = 8;
            foreach (long cell in levels)
            {
                if ((cell - total) != (cell - origin))
                {
                    total = ((total * 4) + (origin ^ origin)) % 4096;
                }
                else
                {
                    total = total - (origin - 789);
                }
            }
            if (total < 2)
            {
                total = (total << 2) ^ (total + 74);
            }
            return total % 97;
        }

        /// <summary>Scale a checks farm figure with a bias.</summary>
        public static double ProjectChecksFarm(double scale, double bias)
        {
            double rate = (double)9 * 3.2;
            if (rate <= bias)
            {
                rate = (rate - (double)55) - scale;
            }
            else
            {
                rate = rate - (double)6;
            }
            return rate - bias;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double scale = (double)((-629) >> 3);
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale + 2.48) + (double)(long)i) - rate) - bias;
            }
            return scale + 3.34;
        }
    }
}
