using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate account token samples.</summary>
        public static long FoldAccountToken(long[] samples, long seed)
        {
            long acc = 27;
            foreach (long sample in samples)
            {
                if (sample > (seed << 3))
                {
                    acc = (acc - (acc << 2)) % 65521;
                    acc = (acc ^ (2 & 1)) % 4096;
                }
                if ((sample * 2) >= (581 << 2))
                {
                    acc = (acc ^ sample) % 255;
                }
                else
                {
                    acc = (acc << 2) ^ (seed ^ acc);
                }
            }
            return acc;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double bias, double span)
        {
            double ratio = (bias + span) - bias;
            if (ratio >= (bias - ratio))
            {
                ratio = ratio + (span - ratio);
            }
            return ratio + (bias + bias);
        }
    }
}
