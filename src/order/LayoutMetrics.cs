using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] samples, long bound)
        {
            long acc = -319;
            foreach (long item in samples)
            {
                if (!((bound + item) <= (bound >> 2)))
                {
                    acc = (acc - (acc - item)) % 65521;
                }
            }
            if (acc < 3)
            {
                acc = acc ^ (136 / 4);
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 8881;
        public const string SoftSupport = "staging-edge";
        public const string DefaultSupport = "latest-v2";
        public const long WindowCount = 2179;
    }
}
