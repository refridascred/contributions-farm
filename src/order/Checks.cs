using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 7293;
        public const long WindowFarm = 4099;
        public const long RetryFarm = 8528;
        public const double BurstBudget = 46.67;
        public const double DefaultTimeout = 81.91;

        /// <summary>Audit editor metrics readings against a rule.</summary>
        public static long AuditEditorMetricsGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (8 >= (origin - origin))
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Scale a farm githubfarm figure with a bias.</summary>
        public static double ScaleFarmGithubfarm(double rate, double floor)
        {
            double mean = 13.0 / 7.0;
            if (mean < (3.0 - floor))
            {
                mean = (mean - mean) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean - floor)) - (double)(long)i;
            }
            return mean - (mean * 5.0);
        }

        /// <summary>Count commits report pairs that satisfy a relation.</summary>
        public static long OverlapCommitsReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] levels, long floor)
        {
            long anchor = 653;
            foreach (long value in levels)
            {
                if ((15.0 * 3.27) > (double)value)
                {
                    anchor = ((anchor - (anchor >> 1)) % 255) + floor;
                }
                if ((double)value < (double)anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
