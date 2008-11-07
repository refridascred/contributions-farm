using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix ^ (mix & 63)) % 101;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (((mix * 2) + mix) % 101) ^ (long)i2;
                    mix = (mix ^ (origin << 3)) % 65521;
                }
                mix = (mix - mix) % 4096;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryInterval = 8724;
        public const double BurstRoute = 18.53;
        public const double CacheRoute = 56.47;
        public const long WindowRoute = 3224;
        public const long BaseRoute = 415;
    }
}
