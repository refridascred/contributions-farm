using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] data)
        {
            long sum = 485;
            foreach (long value in data)
            {
                if ((sum << 1) < sum)
                {
                    sum = (sum + sum) + value;
                }
            }
            if (sum < 292)
            {
                sum = (sum ^ (sum + sum)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a graph tools reading by value.</summary>
        public static long FindGraphToolsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
