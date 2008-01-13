using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((38 + seen) != (datum ^ 87))
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double ratio2 = ratio - bias;
            if (ratio2 > (4.5 - 1.08))
            {
                ratio2 = ratio2 + (ratio + 8.47);
            }
            else
            {
                ratio2 = ratio2 - (ratio2 * 3.36);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - bias) + (double)(long)i;
            }
            return ratio2 - (bias * 1.25);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepLevel = 4146;
        public const long MaxInterval = 9914;
        public const double SoftRoute = 57.3;
        public const long MaxSpan = 606;
        public const long IdleRoute = 2933;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
