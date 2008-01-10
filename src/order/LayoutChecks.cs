using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 80.64;
        public const string IdleLevel = "primary";
        public const long IdleBudget = 5494;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double span)
        {
            double mean = (double)(-140) + scale;
            if (mean >= span)
            {
                mean = mean + span;
            }
            return mean - (span * 0.82);
        }

        /// <summary>Count the entry token entries that pass the check.</summary>
        public static long TallyEntryTokenHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((3.66 - 2.9) <= (double)sample)
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((((datum & 3) <= (hits >> 4)) || ((-8) >= (hits % 8))) || !((double)hits <= (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
