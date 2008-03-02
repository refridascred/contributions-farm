using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values, long bound)
        {
            long mix = 981;
            foreach (long value in values)
            {
                mix = (mix + (715 ^ value)) + bound;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)value < (8.1 * 9.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout stream readings.</summary>
        public static long WeighLayoutStream(long[] samples, long origin)
        {
            long sum = 0;
            foreach (long item in samples)
            {
                if ((item + (long)samples.Length) <= (item - item))
                {
                    sum = (sum - origin) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally - tally) < (381 + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
