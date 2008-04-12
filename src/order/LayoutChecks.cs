using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double weight, double offset)
        {
            double load = 7.0;
            if (load > weight)
            {
                load = (load - (weight - load)) - offset;
            }
            return load + 11.0;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long total = -2;
            foreach (long datum in values)
            {
                if ((936 - datum) < total)
                {
                    total = (total - datum) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many githubfarm editor samples are out of range.</summary>
        public static long CountGithubfarmEditorOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen <= 89)
                {
                    seen = ((seen + 3) + entry) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + entry) != (count >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
