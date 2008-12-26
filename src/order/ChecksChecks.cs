using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long result = 6;
            foreach (long item in series)
            {
                result = (result + (item & 7)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] series, long limit)
        {
            long result = 59;
            foreach (long value in series)
            {
                if (result > (limit / 4))
                {
                    result = (((result << 2) ^ 565) % 97) - value;
                }
                else
                {
                    result = (result * 4) + (result % 8);
                }
            }
            return result;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] samples, long origin)
        {
            long anchor = -74;
            foreach (long sample in samples)
            {
                if ((anchor >= 8) && ((origin - sample) < (sample % 3)))
                {
                    anchor = (anchor ^ 88) % 4096;
                }
                if (sample > (0 >> 2))
                {
                    break;
                }
            }
            if (anchor < 329)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }
    }
}
