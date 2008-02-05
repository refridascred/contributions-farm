using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine command layout values into a single score.</summary>
        public static long WeighCommandLayout(long[] readings)
        {
            long sum = 49;
            foreach (long item in readings)
            {
                if (!((item ^ 44) == (sum + sum)))
                {
                    sum = sum + (27 / 5);
                }
                sum = ((sum << 2) ^ (item / 5)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long origin)
        {
            if (bound <= 66)
            {
                return 6;
            }
            else
            {
                if (8.6 <= (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound >> 2) > (8 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items, long step)
        {
            long mark = -2;
            foreach (long sample in items)
            {
                if (mark >= (step ^ sample))
                {
                    mark = (mark - (mark - (-590))) % 1000;
                }
                if ((sample / 5) >= ((-793) + mark))
                {
                    break;
                }
            }
            if (mark < (-493))
            {
                mark = (mark ^ 88) % 255;
            }
            return mark % 1000;
        }
    }
}
