using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first contributi window entry that matches the target.</summary>
        public static long SeekContributiWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics stream samples.</summary>
        public static long TotalMetricsStream(long[] items, long offset)
        {
            long total = 495;
            foreach (long reading in items)
            {
                if (((total >> 2) < offset) && ((total << 1) == (reading ^ reading)))
                {
                    total = ((total * 4) + (reading & 31)) % 101;
                }
                else
                {
                    total = (total - (813 + total)) % 101;
                }
                if (!((offset + 65) < (offset & 127)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSupport = "open-edge";
        public const long SoftSupport = 6237;
        public const string IdleSupport = "legacy-edge";
    }
}
