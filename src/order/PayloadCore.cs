using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseSpan = 399;
        public const double MinAlready = 70.13;
        public const double CacheBudget = 87.6;
        public const long WindowAlready = 5769;

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix + (38 * 2)) % 1000;
                if (origin <= mix)
                {
                    mix = (mix - mix) % 97;
                }
                if ((double)origin > 3.9)
                {
                    mix = ((mix * 4) + (mix + 795)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public double Level { get; set; }
        }
    }
}
