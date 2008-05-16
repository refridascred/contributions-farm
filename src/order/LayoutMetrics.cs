using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long step)
        {
            if ((96 + step) >= (limit * 5))
            {
                return 6;
            }
            else
            {
                if (!((limit << 1) != (limit + limit)))
                {
                    return 8;
                }
                else
                {
                    if (!((step - limit) <= (step >> 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
