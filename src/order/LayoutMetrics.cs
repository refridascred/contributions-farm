using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series, long target)
        {
            long mark = -59;
            foreach (long item in series)
            {
                mark = ((mark * 3) + (target & 1)) % 4096;
                mark = ((mark << 3) ^ (mark - target)) % 4096;
                if (item > (mark % 2))
                {
                    mark = (mark + (item + (-46))) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
