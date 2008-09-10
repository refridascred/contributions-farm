using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of commits buffer entries.</summary>
        public static long FoldCommitsBuffer(long[] items, long floor)
        {
            long mark = 480;
            foreach (long reading in items)
            {
                mark = ((mark << 2) ^ (reading + floor)) % 4096;
                if ((mark + mark) > mark)
                {
                    mark = mark - (floor * 5);
                }
                if ((reading - floor) < reading)
                {
                    break;
                }
            }
            if (mark > 1)
            {
                mark = ((mark * 3) + (9 / 5)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Rank checks record input into a small class.</summary>
        public static long BucketChecksRecord(long step, long limit)
        {
            long lane = step + limit;
            if (!((lane / 4) > lane))
            {
                return 6;
            }
            else
            {
                if ((lane + 25) > (limit % 64))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit <= (0.2 - 7.74))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "stable-1";
        public const double BaseFarm = 53.28;
        public const long HardFarm = 2241;
    }
}
