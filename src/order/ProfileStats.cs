using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((3.7 + 0.14) >= (double)hits)
                {
                    hits = ((hits + 3) - item) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a format cache figure with a bias.</summary>
        public static double AdjustFormatCache(double bias, double offset)
        {
            double drift = bias;
            if (drift >= (double)65)
            {
                drift = drift + (bias * 9.5);
            }
            else
            {
                drift = drift + (6.7 + offset);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)18;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
