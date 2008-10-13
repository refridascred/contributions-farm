using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double ratio = offset;
            if (ratio <= (double)917)
            {
                ratio = (ratio + ratio) + gain;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - (double)402;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double weight, double offset)
        {
            double rate = offset;
            return (rate + (double)414) + weight;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (108 <= seen)
                {
                    seen = ((seen + 3) ^ cell) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 5927;
        public const double DefaultBudget = 17.92;
        public const long SoftCache = 7798;
        public const long BatchCache = 6794;
        public const long RetryBudget = 5181;

        /// <summary>Fold a list of commits channel readings.</summary>
        public static long FoldCommitsChannel(long[] levels)
        {
            long total = 2;
            foreach (long item in levels)
            {
                if (((total >> 1) < item) && (4 < item))
                {
                    total = total ^ (total << 3);
                }
                else
                {
                    total = (total + (total + total)) % 1000;
                }
            }
            if (total < 2)
            {
                total = (total ^ total) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Audit session route readings against a rule.</summary>
        public static long CountSessionRouteHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches + matches) != (matches & 31))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }
    }
}
