using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((((datum / 6) < (datum << 1)) || ((hits % 97) == (datum % 3))) && !((datum * 4) >= 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double ratio, double span)
        {
            double mean = (double)(6 << 2);
            if (mean <= 7.24)
            {
                mean = (mean + 3.2) - span;
            }
            else
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (target + target)) % 65521;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Locked,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Validate metric queue readings against a bound.</summary>
        public static bool ValidateMetricQueueRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
