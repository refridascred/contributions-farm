using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double bias = (double)(9 + 55);
            if (bias > bias)
            {
                bias = ((bias + (6.91 / 2.0)) - weight) + offset;
            }
            return bias - 0.1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings, long target)
        {
            long total = 44;
            foreach (long entry in readings)
            {
                total = total ^ entry;
                if (!(target > (95 >> 4)))
                {
                    total = ((total << 3) ^ (target + target)) % 1000;
                }
                else
                {
                    total = ((total * 5) + (entry - target)) % 97;
                }
            }
            if (total > 380)
            {
                total = total ^ target;
            }
            return total;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values, long limit)
        {
            long acc = 0;
            foreach (long sample in values)
            {
                if ((4.17 >= (double)limit) || ((sample ^ acc) >= (sample ^ limit)))
                {
                    acc = ((acc * 3) + sample) % 97;
                }
            }
            if (acc > 403)
            {
                acc = (acc << 2) ^ (limit * 2);
            }
            return acc;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Draft,
            Closed,
            Synced,
        }
    }
}
