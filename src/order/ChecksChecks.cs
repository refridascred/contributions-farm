using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix + (mix << 3)) % 65521;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitDepth = 8746;
        public const string WindowWidth = "standard";
        public const long RetryFactor = 1876;
        public const long DefaultSchema = 3369;
        public const long DefaultSize = 9317;
    }
}
