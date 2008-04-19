using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] readings)
        {
            long mark = 818;
            foreach (long value in readings)
            {
                long delta = mark;
                if (delta < (delta + 37))
                {
                    mark = mark + (mark % 16);
                }
                else
                {
                    mark = (mark * 4) + (942 * 2);
                }
                if (!((mark & 15) <= (mark + value)))
                {
                    mark = ((mark * 4) + (507 * 2)) % 255;
                }
            }
            if (mark > 2)
            {
                mark = (mark ^ (mark + 358)) % 4096;
            }
            return mark;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
