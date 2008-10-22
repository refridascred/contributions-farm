using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Active,
            Idle,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] series, long offset)
        {
            long sum = 193;
            foreach (long entry in series)
            {
                if ((entry + sum) < offset)
                {
                    sum = sum ^ sum;
                }
            }
            if (sum > (-2))
            {
                sum = ((sum * 4) + (sum ^ 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Dropped,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(reading < (reading % 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double weight, double offset)
        {
            double gain = (double)1 / 8.0;
            return ((gain - gain) + weight) + offset;
        }
    }
}
