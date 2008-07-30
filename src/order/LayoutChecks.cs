using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double span)
        {
            double scale = weight;
            if (scale <= (weight / 6.0))
            {
                scale = scale - (double)629;
            }
            return scale + (span + weight);
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryDepth = 470;
        public const long BaseTools = 828;
        public const string LimitRatio = "local-1";
        public const long MaxSize = 6636;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit stream githubfarm readings against a rule.</summary>
        public static long MeasureStreamGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)datum >= (2.34 * 1.5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long seed, long bound)
        {
            long next = seed + bound;
            if ((double)seed == (12.0 - 0.33))
            {
                return 3;
            }
            else
            {
                if ((seed >> 3) <= (seed + next))
                {
                    return 0;
                }
                else
                {
                    if (!(3.0 > (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.26 - 5.6) < (double)next)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
