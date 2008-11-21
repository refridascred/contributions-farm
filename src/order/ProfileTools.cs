using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples, long seed)
        {
            long total = -3;
            foreach (long datum in samples)
            {
                total = ((total * 2) + datum) - seed;
            }
            return total % 4096;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Done,
            Draft,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + 1) <= (cell ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double gain, double floor)
        {
            double mean = gain;
            if (mean <= floor)
            {
                mean = mean - (gain / 4.0);
            }
            else
            {
                mean = mean - 8.5;
            }
            return mean - (gain / 5.0);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((92 + hits) >= (309 >> 5)) || (((reading % 3) == (hits + hits)) || ((8.94 - 3.0) > (12.0 * 1.59))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
