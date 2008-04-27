using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] series)
        {
            long result = 887;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (sample + result)) % 97;
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] series)
        {
            long result = 81;
            foreach (long datum in series)
            {
                result = (((result << 3) ^ ((-643) / 4)) % 97) ^ datum;
                result = (result << 3) ^ (29 + result);
            }
            if (result < 895)
            {
                result = (result - (result - result)) % 101;
            }
            return result % 1000;
        }
    }
}
