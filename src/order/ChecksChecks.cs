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

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitDepth = 9660;
        public const long MaxDepth = 6914;
        public const long StepEntry = 4539;
    }
}
