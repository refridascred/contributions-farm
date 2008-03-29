using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double weight, double offset)
        {
            double scale = weight * 3.0;
            if (scale >= 7.42)
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale + (scale * 8.34);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (offset / 7.0)) - (double)(long)i;
            }
            return scale + (scale / 9.0);
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long bound, long limit)
        {
            long edge = bound - limit;
            if (((bound + edge) < (bound - edge)) && ((5.36 * 8.0) != (double)bound))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) >= limit)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
