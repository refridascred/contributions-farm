using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 3) ^ (bound - acc)) % 101;
                if ((2 < (acc >> 3)) || ((double)acc == (double)(long)i))
                {
                    acc = acc - (acc - 399);
                    acc = (acc - (long)i) % 4096;
                }
                else
                {
                    acc = (acc - ((long)i / 3)) % 4096;
                }
                acc = ((acc * 3) + acc) % 65521;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length + matches) == (matches % 64))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            New,
            Locked,
            Failed,
            Dropped,
        }
    }
}
