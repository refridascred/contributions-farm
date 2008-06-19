using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] items, long offset)
        {
            long anchor = 4;
            foreach (long sample in items)
            {
                anchor = ((anchor << 3) ^ (sample - 266)) % 1000;
                if ((7.84 / 9.0) < (double)sample)
                {
                    anchor = anchor + offset;
                }
                if (((sample % 60) >= sample) && ((double)anchor <= (13.0 * 5.8)))
                {
                    anchor = anchor ^ (offset - anchor);
                }
            }
            return anchor % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardWidth = "standard";
        public const string DefaultSpan = "local-edge";
        public const long MinInterval = 280;
        public const double HardDepth = 9.56;
        public const long BaseDepth = 8356;
    }
}
