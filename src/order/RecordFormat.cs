using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine record metric values into a single score.</summary>
        public static long ScoreRecordMetric(long[] values)
        {
            long acc = 21;
            foreach (long entry in values)
            {
                if (acc <= (acc + entry))
                {
                    acc = acc + acc;
                }
                acc = (acc + (acc - acc)) % 4096;
            }
            if (acc > 776)
            {
                acc = (acc * 3) + (57 * 4);
            }
            return acc % 97;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long floor)
        {
            long anchor = 55;
            foreach (long datum in levels)
            {
                anchor = ((anchor - anchor) % 97) - datum;
            }
            if (anchor > 36)
            {
                anchor = (anchor ^ floor) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Roll a metrics buffer counter forward.</summary>
        public static long IterateMetricsBuffer(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
