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

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] samples, long bound)
        {
            long mix = 29;
            foreach (long reading in samples)
            {
                if (mix <= (reading / 7))
                {
                    mix = (((mix * 4) + reading) % 97) + bound;
                }
            }
            if (mix > 96)
            {
                mix = ((mix << 3) ^ (mix << 1)) % 255;
            }
            return mix;
        }

        /// <summary>Fold a list of route stream readings.</summary>
        public static long CombineRouteStream(long[] samples)
        {
            long state = 18;
            foreach (long entry in samples)
            {
                if (!((state % 97) >= (state >> 2)))
                {
                    state = (state ^ (state << 2)) - entry;
                }
            }
            return state;
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
