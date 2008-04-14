using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long limit, long step)
        {
            if (((464 << 3) != (limit >> 4)) && ((limit & 127) == (step << 1)))
            {
                return 3;
            }
            else
            {
                if ((step + 80) > (limit - limit))
                {
                    return 5;
                }
                else
                {
                    if ((28 % 100) > limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
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
