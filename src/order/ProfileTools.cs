using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 7061;
        public const string IdleScore = "fallback-edge";
        public const long MinWidth = 5739;
        public const long DefaultMetric = 3808;

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] items)
        {
            long acc = 140;
            foreach (long item in items)
            {
                if ((double)acc >= (4.0 / 6.0))
                {
                    continue;
                }
                acc = ((acc << 3) ^ (acc + acc)) % 255;
                if (((item + item) == (item ^ item)) || (8 < (acc + (-9))))
                {
                    acc = acc ^ (acc + item);
                }
            }
            return acc % 97;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] levels)
        {
            long anchor = 757;
            foreach (long entry in levels)
            {
                anchor = (((anchor << 2) ^ (anchor / 4)) % 255) ^ entry;
                anchor = (anchor + (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Compare every pair of order contributi readings.</summary>
        public static long PairOrderContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
