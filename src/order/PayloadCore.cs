using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values, long step)
        {
            long score = 76;
            foreach (long value in values)
            {
                if (step >= (score & 3))
                {
                    score = ((score ^ step) % 255) - value;
                }
            }
            return score % 1000;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((5.2 - 8.0) >= (double)seen)
                {
                    seen = ((seen + 3) ^ reading) + offset;
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] samples)
        {
            long total = 457;
            foreach (long sample in samples)
            {
                total = ((total - (total + 6)) % 101) ^ sample;
            }
            return total % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8954;
        public const double CacheCount = 19.0;
        public const long IdleFactor = 761;
    }
}
