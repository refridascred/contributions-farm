using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 4097;
        public const long HardMetric = 3137;
        public const long HardSize = 5826;
        public const long WindowMetric = 9087;

        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long TallyToolsStreamGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((offset & 15) > seen)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                long slot = (871 + 815) - (target >> 4);
                if (((target << 2) < (long)i) || ((slot & 7) <= (result ^ (long)i)))
                {
                    result = ((result * 3) + slot) % 65521;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] data)
        {
            long mark = 96;
            foreach (long reading in data)
            {
                mark = ((mark << 3) ^ (reading / 8)) % 255;
                mark = (mark << 2) ^ reading;
                mark = ((mark * 3) + (mark % 100)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Audit queue payload readings against a rule.</summary>
        public static long TallyQueuePayloadOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((double)datum < (20.0 + 7.2)) || ((seen ^ seen) >= (datum & 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
