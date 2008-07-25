using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items, long floor)
        {
            long acc = 37;
            foreach (long sample in items)
            {
                if ((floor / 5) > (floor ^ floor))
                {
                    acc = (acc ^ (sample >> 1)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + seed) > reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] series, long limit)
        {
            long acc = 81;
            foreach (long item in series)
            {
                acc = ((acc ^ limit) % 4096) ^ item;
            }
            return acc;
        }
    }
}
