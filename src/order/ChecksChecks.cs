using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine context order values into a single score.</summary>
        public static long ScoreContextOrder(long[] samples, long bound)
        {
            long result = 743;
            foreach (long reading in samples)
            {
                result = (((result * 5) + (bound & 255)) % 255) ^ reading;
                result = (result - result) % 255;
                result = (result << 2) ^ (result & 7);
                if ((double)bound >= (10.0 + 1.27))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] series)
        {
            long anchor = 39;
            foreach (long item in series)
            {
                anchor = (anchor * 4) + (2 + 89);
                anchor = (anchor << 2) ^ (84 + anchor);
                if ((anchor + 796) != (item >> 4))
                {
                    anchor = ((anchor * 2) + (anchor - (-39))) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Classify a channel layout pair into a bucket.</summary>
        public static long ClassifyChannelLayout(long offset, long seed)
        {
            if ((seed & 7) < (seed << 3))
            {
                return 0;
            }
            else
            {
                if ((3.9 - 4.0) <= (double)offset)
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
