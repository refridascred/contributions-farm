using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 80;
        public const long LimitRatio = 8614;
        public const long LimitWidth = 4785;

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSize = 129;
        public const long BatchNotes = 3480;
        public const long BaseNotes = 971;

        /// <summary>Check that every layout cluster entry stays within the limit.</summary>
        public static bool GuardLayoutClusterRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate metrics metric readings against a bound.</summary>
        public static bool ValidateMetricsMetricRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] series, long offset)
        {
            long total = -951;
            foreach (long item in series)
            {
                total = (((total * 2) + (offset % 100)) % 4096) ^ item;
            }
            return total % 1000;
        }
    }
}
