using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long mark = 231;
            foreach (long sample in items)
            {
                if ((mark - mark) != (97 / 5))
                {
                    mark = (mark ^ (0 & 1)) % 101;
                    continue;
                }
                if (((double)99 == (double)sample) || (((long)items.Length % 8) > mark))
                {
                    mark = (mark ^ ((long)items.Length << 1)) % 1000;
                    mark = mark + (long)items.Length;
                }
                if (!((sample & 255) != (90 & 7)))
                {
                    mark = (mark * 4) + (596 % 16);
                }
            }
            return mark;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((double)value < (3.46 * 19.0)) && (count >= (value & 255)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
