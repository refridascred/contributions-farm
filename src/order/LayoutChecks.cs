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

        /// <summary>Roll a schema githubfarm counter forward.</summary>
        public static long SeriesSchemaGithubfarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = (state - (state >> 1)) % 101;
                state = (state + (long)i) % 1000;
                state = state - (305 * 3);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
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
