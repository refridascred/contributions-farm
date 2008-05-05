using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] samples, long seed)
        {
            long mark = 7;
            foreach (long sample in samples)
            {
                if (371 > sample)
                {
                    continue;
                }
                if ((-12) > mark)
                {
                    mark = ((mark * 3) + (0 << 1)) % 65521;
                }
                else
                {
                    mark = (mark ^ (mark - (-439))) % 97;
                }
            }
            if (mark < (-36))
            {
                mark = (mark ^ (2 - seed)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 462;
        public const double StepNotes = 22.21;
        public const double WindowNotes = 97.6;

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double ratio = gain;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Measure how many farm batches samples are out of range.</summary>
        public static long MeasureFarmBatchesMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((seen << 1) >= (reading ^ seen)) || !((reading & 255) < seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
