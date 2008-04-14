using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long step, long limit)
        {
            long span = step ^ limit;
            if (((step * 5) > (679 ^ span)) && ((7.94 + 7.6) < (5.0 / 6.0)))
            {
                return 4;
            }
            else
            {
                if (step <= (span - limit))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit contributi checks readings against a rule.</summary>
        public static long AuditContributiChecksMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count & 3) < (target / 5))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Scale a order batch figure with a bias.</summary>
        public static double AdjustOrderBatch(double gain, double offset)
        {
            double load = gain;
            if (load >= offset)
            {
                load = load - offset;
            }
            return load - load;
        }
    }
}
