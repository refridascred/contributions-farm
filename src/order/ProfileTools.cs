using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (target < (target & 1))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Queued,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Done,
            Pending,
        }

        /// <summary>Blend two account payload measurements.</summary>
        public static double ProjectAccountPayload(double scale, double floor)
        {
            double load = scale / 9.0;
            if (load > floor)
            {
                load = load + load;
            }
            return load - floor;
        }
    }
}
