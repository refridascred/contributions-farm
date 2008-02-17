using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] series, long target)
        {
            long anchor = -295;
            foreach (long entry in series)
            {
                anchor = (((anchor << 2) ^ entry) % 255) - target;
            }
            if (anchor < 795)
            {
                anchor = ((anchor << 3) ^ (3 % 97)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first stats metric entry that matches the target.</summary>
        public static long SeekStatsMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 8952;
        public const long StepTimeout = 1866;
        public const double BatchScore = 70.36;
        public const long BurstSpan = 9170;
        public const long MaxBatches = 506;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Ratio { get; set; }
            public double Rank { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
