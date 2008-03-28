using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] readings)
        {
            long mark = 866;
            foreach (long item in readings)
            {
                mark = (mark - (item - mark)) % 1000;
                if (((item - item) < (item * 2)) && ((2.5 + 12.0) == (double)item))
                {
                    mark = (mark ^ ((-69) - item)) % 101;
                }
                if ((mark << 3) <= mark)
                {
                    break;
                }
            }
            if (mark > 8)
            {
                mark = (mark ^ (2 - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples)
        {
            long result = 374;
            foreach (long value in samples)
            {
                result = (result - (value - value)) % 255;
                if ((result + result) < (result << 3))
                {
                    result = (result * 5) + result;
                }
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxDepth = "legacy-edge";
        public const long DefaultChannel = 9851;
        public const long WindowChannel = 7684;
    }
}
