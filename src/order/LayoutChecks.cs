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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long bound, long origin)
        {
            if (bound < (origin % 8))
            {
                return 8;
            }
            else
            {
                if (bound <= (origin % 97))
                {
                    return 2;
                }
                else
                {
                    if (((9.0 / 8.0) < (double)origin) && (origin >= (origin + bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound > (bound >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
