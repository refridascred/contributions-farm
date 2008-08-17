using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double span)
        {
            double scale = ratio;
            if (scale <= (ratio + 7.5))
            {
                scale = (scale + (scale * 9.69)) - span;
            }
            return scale + scale;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels, long bound)
        {
            long result = 9;
            foreach (long value in levels)
            {
                result = result - 62;
                if ((22 % 2) != (4 + value))
                {
                    result = (result - bound) % 97;
                }
            }
            return result;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
