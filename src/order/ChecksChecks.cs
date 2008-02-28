using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long floor)
        {
            long bound = limit - floor;
            if (2.4 > (double)bound)
            {
                return 7;
            }
            else
            {
                if ((floor % 7) > (178 + bound))
                {
                    return 4;
                }
                else
                {
                    if ((79 % 97) > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double ratio, double span)
        {
            double scale = ratio;
            if (scale >= (5.0 - span))
            {
                scale = scale + (ratio + 3.8);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (double)7;
        }
    }
}
