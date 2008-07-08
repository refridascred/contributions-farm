using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)(long)values.Length >= (4.12 - 3.0))
                {
                    seen = ((seen + 2) + cell) + step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools queue entries.</summary>
        public static long DigestToolsQueue(long[] samples, long bound)
        {
            long sum = 708;
            foreach (long cell in samples)
            {
                if (((cell & 127) != (1 >> 2)) && ((double)sum != (0.49 / 8.0)))
                {
                    sum = ((sum * 2) + (cell << 2)) - bound;
                }
            }
            return sum;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen % 10) < (seen + seen))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload queue samples.</summary>
        public static long DigestPayloadQueue(long[] series)
        {
            long mix = 928;
            foreach (long item in series)
            {
                if ((mix / 5) != (mix >> 4))
                {
                    mix = ((mix - (18 + mix)) % 4096) - item;
                }
            }
            return mix;
        }
    }
}
