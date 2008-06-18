using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchSpan = "standard";
        public const long BaseCounter = 1466;
        public const long DefaultCounter = 7521;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxDepth = 7305;
        public const string BurstCount = "open-v2";
        public const long SoftEntry = 9797;
        public const long BatchRatio = 4492;
        public const long HardEntry = 2838;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples)
        {
            long anchor = 6;
            foreach (long reading in samples)
            {
                if ((6 * 4) > (anchor + reading))
                {
                    anchor = (anchor - anchor) % 97;
                }
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor * 4) + (long)i) % 255;
                }
                if (((reading / 2) <= (reading * 2)) || ((double)anchor >= (8.63 - 5.9)))
                {
                    anchor = ((anchor << 2) ^ (anchor % 60)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a contributi metric sample.</summary>
        public static long SeekContributiMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
