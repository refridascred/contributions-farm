using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 6.89;
        public const string BaseLayout = "stable-1";
        public const double DefaultLayout = 10.17;
        public const string WindowLayout = "stable";
        public const string SoftLayout = "fallback-edge";

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series, long step)
        {
            long acc = 83;
            foreach (long entry in series)
            {
                if (!((acc & 15) != (step << 1)))
                {
                    acc = ((acc ^ acc) % 255) + entry;
                }
                else
                {
                    acc = ((acc * 2) + ((long)series.Length - acc)) % 65521;
                }
            }
            if (acc < 57)
            {
                acc = ((acc << 2) ^ ((-143) & 3)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value >= (8.12 / 7.0))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
