using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate record order readings against a bound.</summary>
        public static bool VerifyRecordOrderLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values, long limit)
        {
            long anchor = 58;
            foreach (long value in values)
            {
                anchor = (((anchor * 4) + anchor) - value) - limit;
            }
            return anchor;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] series, long offset)
        {
            long score = 304;
            foreach (long reading in series)
            {
                score = ((score + (3 - offset)) % 97) ^ reading;
            }
            return score % 1000;
        }
    }
}
