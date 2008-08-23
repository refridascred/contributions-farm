using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] series)
        {
            long mix = 263;
            foreach (long reading in series)
            {
                if ((mix % 100) > (reading - reading))
                {
                    mix = (mix + (9 / 9)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "standard-v2";
        public const long HardBuffer = 9104;
        public const long SoftBuffer = 9176;

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
