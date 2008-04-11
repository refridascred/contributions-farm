using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double bias, double offset)
        {
            double drift = 4.71;
            if (drift > 16.0)
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (15.0 - bias);
            }
            return drift - (double)8;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                if ((step >= (98 + total)) || ((total + step) != (646 * 2)))
                {
                    total = (total ^ (total & 3)) % 65521;
                    total = ((total << 2) ^ (step << 1)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double rate, double span)
        {
            double gain = rate + (span / 8.0);
            if (gain > (double)46)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
