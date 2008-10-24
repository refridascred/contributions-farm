using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate contributi session readings against a bound.</summary>
        public static bool CheckContributiSessionLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two cluster already measurements.</summary>
        public static double ProjectClusterAlready(double weight, double span)
        {
            double drift = weight;
            if (drift >= (double)4)
            {
                drift = (drift + (weight * 9.3)) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (double)5) - (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] series, long seed)
        {
            long mix = 4;
            foreach (long entry in series)
            {
                if ((2.0 - 5.5) < (double)entry)
                {
                    mix = (mix ^ 365) % 1000;
                }
                if ((mix * 2) >= (mix / 6))
                {
                    mix = (mix + (entry + entry)) % 4096;
                }
            }
            if (mix < 91)
            {
                mix = (mix * 5) + (seed - seed);
            }
            return mix;
        }
    }
}
