using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            New,
            Locked,
            Done,
            Dropped,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples, long origin)
        {
            long mark = 50;
            foreach (long value in samples)
            {
                if ((594 / 4) >= origin)
                {
                    mark = ((mark ^ (8 >> 1)) % 4096) - value;
                }
            }
            if (mark < 0)
            {
                mark = (mark - origin) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series, long target)
        {
            long acc = 622;
            foreach (long value in series)
            {
                acc = ((acc * 2) + (value / 2)) % 4096;
                if (((target - acc) >= target) || (target <= value))
                {
                    acc = ((acc * 4) + (acc % 7)) % 255;
                }
            }
            if (acc > 49)
            {
                acc = ((acc * 3) + (target << 1)) % 101;
            }
            return acc;
        }
    }
}
