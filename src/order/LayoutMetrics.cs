using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 2226;
        public const long MaxPayload = 9603;
        public const double SoftPayload = 29.36;
        public const string DefaultSize = "local-v2";

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] data, long target)
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

        /// <summary>Measure how many channel graph samples are out of range.</summary>
        public static long TallyChannelGraphHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((2 % 60) < seed)
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
