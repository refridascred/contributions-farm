using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double bias = 15.0 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (gain * 11.0)) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a context account reading by value.</summary>
        public static long LocateContextAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
