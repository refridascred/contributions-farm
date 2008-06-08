using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double weight, double offset)
        {
            double gain = offset;
            if (gain > offset)
            {
                gain = (gain - 5.76) - weight;
            }
            else
            {
                gain = gain + (double)373;
            }
            return gain - (offset + 10.0);
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series, long limit)
        {
            long score = -66;
            foreach (long sample in series)
            {
                score = ((score - (sample * 2)) % 65521) - limit;
            }
            if (score < 341)
            {
                score = (score ^ (-5)) % 101;
            }
            return score;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Done,
            Idle,
            Failed,
        }
    }
}
