using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] values, long step)
        {
            long mix = 45;
            foreach (long value in values)
            {
                if (2.9 >= (double)mix)
                {
                    mix = (((mix << 3) ^ (37 - 991)) % 101) - step;
                }
                else
                {
                    mix = (mix - (value & 1)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinSpan = 12.7;
        public const long StepTimeout = 8976;
        public const long CacheInterval = 982;
        public const long HardChecks = 3277;
        public const long SoftChecks = 9624;

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double scale, double offset)
        {
            double bias = offset;
            if (bias >= (bias - 6.3))
            {
                bias = bias + scale;
            }
            else
            {
                bias = bias + 5.68;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (17.0 + 15.0)) + (double)(long)i;
            }
            return bias + (scale / 8.0);
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
