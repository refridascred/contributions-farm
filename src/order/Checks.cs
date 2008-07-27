using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double weight = (offset + gain) / 2.0;
            if (weight <= 7.39)
            {
                weight = weight - (weight * 6.3);
            }
            else
            {
                weight = weight - gain;
            }
            return weight - gain;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit already farm readings against a rule.</summary>
        public static long TallyAlreadyFarmOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits % 7) < (hits & 31))
                {
                    hits = ((hits + 3) + cell) + offset;
                }
            }
            return hits;
        }
    }
}
