using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((floor + sample) <= (floor / 6)) || ((seen & 3) != (seen ^ sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 9300;
        public const double WindowContributi = 29.23;
        public const long MaxContributi = 2058;
        public const long DefaultContributi = 6742;
        public const double LimitContributi = 61.5;

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + mix) % 101;
                if (((12.0 - 15.0) >= (double)(long)i) && ((mix >> 5) <= (long)i))
                {
                    mix = (mix ^ (long)i) % 97;
                    mix = ((mix << 3) ^ floor) % 1000;
                }
                mix = (mix - ((long)i * 4)) % 97;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
