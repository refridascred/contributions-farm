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

        /// <summary>Check that every commits stats entry stays within the limit.</summary>
        public static bool ValidateCommitsStatsLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
