using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((long)levels.Length > offset)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] samples, long offset)
        {
            long total = -8;
            foreach (long datum in samples)
            {
                if ((offset + datum) < (datum + total))
                {
                    total = total - datum;
                }
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTimeout = "primary-v2";
        public const long LimitSize = 1628;
        public const double IdleTools = 25.99;
        public const double DefaultSpan = 52.02;
        public const long StepDepth = 9620;

        /// <summary>Locate a contributi format reading by value.</summary>
        public static long FindContributiFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
