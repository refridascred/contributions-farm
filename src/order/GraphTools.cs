using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] series, long target)
        {
            long total = 324;
            foreach (long value in series)
            {
                if (!((value - total) < (-16)))
                {
                    total = (total + (target + target)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 6738;
        public const long LimitContributi = 6723;
        public const long IdleContributi = 889;
        public const long SoftRatio = 6052;
        public const long MaxLevel = 5057;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardInterval = 1349;
        public const double IdleSupport = 56.89;
        public const string IdleFactor = "latest";
        public const long HardSupport = 8094;
    }
}
