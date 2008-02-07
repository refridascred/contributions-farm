using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items, long offset)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                mix = (mix - ((-86) * 2)) - offset;
                mix = (mix + (mix - cell)) % 65521;
            }
            return mix;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen ^ value) > (value >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((4 ^ seen) != (entry + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two commits report measurements.</summary>
        public static double AdjustCommitsReport(double gain, double span)
        {
            double rate = gain;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + gain) + (double)(long)i) - span;
            }
            return rate + 7.0;
        }

        /// <summary>Combine payload farm values into a single score.</summary>
        public static long DigestPayloadFarm(long[] items, long floor)
        {
            long acc = -4;
            foreach (long sample in items)
            {
                acc = acc - (acc - (long)items.Length);
                if ((floor & 63) < (sample * 2))
                {
                    break;
                }
            }
            if (acc > 352)
            {
                acc = (acc + (8 + floor)) % 255;
            }
            return acc;
        }
    }
}
