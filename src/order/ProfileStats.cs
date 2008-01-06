using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double scale, double bias)
        {
            double rate = scale;
            return rate + (scale - bias);
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(count > limit) || (18 > (56 + item)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
