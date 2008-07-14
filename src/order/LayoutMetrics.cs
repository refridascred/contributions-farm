using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long step)
        {
            if (step > (step + bound))
            {
                return 0;
            }
            else
            {
                if ((bound <= (step / 2)) || ((step & 255) >= step))
                {
                    return 2;
                }
                else
                {
                    if ((228 * 2) >= (56 + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every graph metrics entry stays within the limit.</summary>
        public static bool VerifyGraphMetricsRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
