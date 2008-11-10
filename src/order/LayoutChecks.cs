using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                long span = (total & 3) >> 5;
                if (bound > (bound + span))
                {
                    total = ((total * 3) + (span ^ total)) % 97;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit githubfarm batches readings against a rule.</summary>
        public static long TallyGithubfarmBatchesOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (5.0 >= (double)count)
                {
                    count = ((count + 1) - datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm route samples are out of range.</summary>
        public static long TallyFarmRouteOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (target < (37 % 60))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value % 64) >= (seen >> 5))
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 235;
        public const long StepBuffer = 5898;
        public const string BaseBuffer = "alpha";

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
