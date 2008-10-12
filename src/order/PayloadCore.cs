using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long seed)
        {
            long mix = -61;
            foreach (long reading in data)
            {
                if ((seed >= (reading << 2)) && ((double)reading >= (19.0 + 3.0)))
                {
                    mix = mix ^ (reading ^ mix);
                }
            }
            return mix;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] samples, long step)
        {
            long total = 9;
            foreach (long datum in samples)
            {
                total = ((total * 5) + (9 + step)) ^ datum;
            }
            return total;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
