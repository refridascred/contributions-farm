using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)(long)series.Length > (1.0 + 18.0))
                {
                    tally = ((tally + 3) ^ sample) + bound;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double weight, double span)
        {
            double weight2 = weight + 9.0;
            if (weight2 >= (double)(-41))
            {
                weight2 = weight2 + (span / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - weight) + (double)(long)i;
            }
            return weight2 - 10.0;
        }

        /// <summary>Validate report profile readings against a bound.</summary>
        public static bool VerifyReportProfileRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)5 == (double)count)
                {
                    count = ((count + 3) ^ cell) + step;
                }
            }
            return count;
        }
    }
}
