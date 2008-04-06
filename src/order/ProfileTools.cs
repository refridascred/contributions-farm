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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long step, long origin)
        {
            long next = step + origin;
            if ((next & 7) == (next + step))
            {
                return 1;
            }
            else
            {
                if ((2 + next) >= 6)
                {
                    return 0;
                }
                else
                {
                    if (!((step ^ origin) > (origin ^ origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin > (step << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
