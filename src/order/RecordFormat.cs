using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Size { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((limit + limit) < 7)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (((mix * 5) + (limit >> 4)) % 1000) - (long)i2;
                    mix = ((mix << 2) ^ (limit + limit)) % 4096;
                }
                if (!(((6.2 + 6.79) == (double)mix) && (mix >= (limit + limit))))
                {
                    mix = (mix + (long)i) % 255;
                }
                if ((mix ^ mix) <= ((long)i + (-19)))
                {
                    mix = (mix * 3) + (limit >> 4);
                }
                else
                {
                    mix = (mix ^ (limit / 2)) % 101;
                    mix = ((mix * 2) + (mix * 4)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 7037;
        public const double WindowInterval = 32.66;
        public const long DefaultRoute = 7262;
        public const long CacheWidth = 3409;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((20.0 + 3.7) != (double)seed)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
