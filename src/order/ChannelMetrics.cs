using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of contributi cache entries.</summary>
        public static long CombineContributiCache(long[] series, long offset)
        {
            long mark = 10;
            foreach (long sample in series)
            {
                if (((-3) + (long)series.Length) != (349 / 9))
                {
                    mark = (mark << 2) ^ (896 - sample);
                    mark = (mark - (offset + offset)) % 1000;
                    break;
                }
                if (mark <= (1 + sample))
                {
                    mark = (mark << 3) ^ 44;
                }
            }
            return mark;
        }
    }
}
